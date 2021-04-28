using System.Collections.ObjectModel;

namespace WpfDeferredResourceLookupRepro.ViewModels
{
    public sealed class TabViewModel : ViewModel
    {
        public TabViewModel(int tabNumber)
        {
            TabName = $"Tab {tabNumber}";

            for (int i = 0; i < 10; i++)
            {
                ThingLists.Add(new ThingListViewModel(i));
            }
        }

        public ObservableCollection<ThingListViewModel> ThingLists { get; } = new();

        public string TabName { get; }
    }
}
