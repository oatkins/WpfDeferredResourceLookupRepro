using System.Collections.ObjectModel;

namespace WpfDeferredResourceLookupRepro.ViewModels
{
    public class ThingListViewModel : ViewModel
    {
        public ThingListViewModel(int number)
        {
            for (int i = 0; i < 500; i++)
            {
                Things.Add(new ThingViewModel(i));
            }
        }

        public ObservableCollection<ThingViewModel> Things { get; } = new();
    }
}
