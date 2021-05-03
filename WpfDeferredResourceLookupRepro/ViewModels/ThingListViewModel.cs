using System.Collections.ObjectModel;
using static WpfDeferredResourceLookupRepro.ViewModels.Constants;

namespace WpfDeferredResourceLookupRepro.ViewModels
{
    public class ThingListViewModel : ViewModel
    {
        public ThingListViewModel(int number)
        {
            for (int i = 0; i < NumberOfItemsPerList; i++)
            {
                Things.Add(new ThingViewModel(i));
            }
        }

        public ObservableCollection<ThingViewModel> Things { get; } = new();
    }
}
