using System.ComponentModel.DataAnnotations;

namespace WpfDeferredResourceLookupRepo.ViewModels
{
    public sealed class ThingViewModel : ViewModel
    {
        public ThingViewModel(int number)
        {
            Display = $"Thing {number}";
        }

        public string Display { get; }
    }
}
