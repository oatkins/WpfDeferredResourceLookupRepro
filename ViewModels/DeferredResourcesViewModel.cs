using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDeferredResourceLookupRepo.ViewModels
{
    public class DeferredResourcesViewModel : ViewModel
    {
        private int _deferredResourceCount;

        public int DeferredResourceCount
        {
            get => _deferredResourceCount;
            set => Set(ref _deferredResourceCount, value);
        }

        public void Initialize()
        {
            _ = UpdateCountAsync();
        }

        private async Task UpdateCountAsync()
        {
            while (true)
            {
                var res = DeferredResourceInfo.GetDeferredResourceInfos().ToList();
                DeferredResourceCount = res.Count;

                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
    }
}
