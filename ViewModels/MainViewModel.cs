using System.Collections.ObjectModel;

namespace WpfDeferredResourceLookupRepo.ViewModels
{
    public class MainViewModel : ViewModel
    {
        public ObservableCollection<TabViewModel> TabViewModels { get; } = new();

        public void Initialize()
        {
            for (int i = 0; i < 20; i++)
            {
                TabViewModels.Add(new TabViewModel(i));
            }
        }
    }
}
