using System.Collections.ObjectModel;
using static WpfDeferredResourceLookupRepro.ViewModels.Constants;

namespace WpfDeferredResourceLookupRepro.ViewModels
{
    public sealed class TabViewModel : ViewModel
    {
        public TabViewModel(int tabNumber)
        {
            TabName = $"Tab {tabNumber}";

            for (int i = 0; i < NumberOfLists; i++)
            {
                ThingLists.Add(new ThingListViewModel(i));
            }
        }

        public ObservableCollection<ThingListViewModel> ThingLists { get; } = new();

        public string TabName { get; }
    }
}
