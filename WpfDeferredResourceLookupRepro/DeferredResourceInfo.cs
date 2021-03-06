using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace WpfDeferredResourceLookupRepro
{
    [DebuggerDisplay(@"{DictionaryIdentity,nq}: {Key,nq}")]
    internal class DeferredResourceInfo
    {
        private static readonly FieldInfo DeferredResourceReferencesField = typeof(ResourceDictionary).GetField("_deferredResourceReferences", BindingFlags.NonPublic | BindingFlags.Instance);

        private static readonly Type DeferredResourceReferenceType = typeof(FrameworkElement).Assembly.GetType(@"System.Windows.DeferredResourceReference");

        private static readonly PropertyInfo KeyPropertyInfo = DeferredResourceReferenceType.GetProperty("Key", BindingFlags.Instance | BindingFlags.NonPublic);

        private DeferredResourceInfo(string dictionaryIdentity, string key)
        {
            DictionaryIdentity = dictionaryIdentity;
            Key = key;
        }

        public string DictionaryIdentity { get; }

        public string Key { get; }

        public static IEnumerable<DeferredResourceInfo> GetDeferredResourceInfos() =>
            from d in GetResourceDictionaries(Application.Current.Resources)
            from r in GetDeferredResourceInfos(d)
            select r;

        private static IEnumerable<DeferredResourceInfo> GetDeferredResourceInfos(ResourceDictionary dictionary)
        {
            var weakReferenceList = (IEnumerable)DeferredResourceReferencesField.GetValue(dictionary);
            if (weakReferenceList == null)
            {
                yield break;
            }

            string dictionaryIdentity = dictionary.Source?.ToString();
            if (dictionaryIdentity == null && dictionary.Contains(@"__Identity"))
            {
                dictionaryIdentity = (string)dictionary["__Identity"];
            }

            foreach (var reference in weakReferenceList)
            {
                yield return new DeferredResourceInfo(dictionaryIdentity, KeyPropertyInfo.GetValue(reference)?.ToString() ?? string.Empty);
            }
        }

        private static IEnumerable<ResourceDictionary> GetResourceDictionaries(ResourceDictionary root)
        {
            if (root == null)
            {
                yield break;
            }

            yield return root;

            foreach (var rd in root.MergedDictionaries)
            {
                foreach (var child in GetResourceDictionaries(rd))
                {
                    yield return child;
                }
            }
        }
    }
}
