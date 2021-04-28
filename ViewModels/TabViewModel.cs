using System.Collections.ObjectModel;

namespace WpfDeferredResourceLookupRepo.ViewModels
{
    public sealed class TabViewModel : ViewModel
    {
        public TabViewModel(int tabNumber)
        {
            TabName = $"Tab {tabNumber}";

            for (int i = 0; i < 500; i++)
            {
                Things.Add(new ThingViewModel(i));
            }
        }

        public ObservableCollection<ThingViewModel> Things { get; } = new();

        public string TabName { get; }
    }
}
