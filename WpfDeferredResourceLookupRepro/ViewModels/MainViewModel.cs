using System.Collections.ObjectModel;

namespace WpfDeferredResourceLookupRepro.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private bool _tabsAdded;

        public ObservableCollection<TabViewModel> TabViewModels { get; } = new();

        public void Initialize()
        {
        }

        internal void AddTabs()
        {
            if (_tabsAdded)
            {
                return;
            }

            for (int i = 0; i < 20; i++)
            {
                TabViewModels.Add(new TabViewModel(i));
            }

            _tabsAdded = true;
        }

        internal void RemoveTabs()
        {
            if (!_tabsAdded)
            {
                return;
            }

            for (int ix = TabViewModels.Count - 1; ix >= 0; ix--)
            {
                TabViewModels.RemoveAt(ix);
            }

            _tabsAdded = false;
        }
    }
}
