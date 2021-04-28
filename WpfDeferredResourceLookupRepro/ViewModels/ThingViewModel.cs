namespace WpfDeferredResourceLookupRepro.ViewModels
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
