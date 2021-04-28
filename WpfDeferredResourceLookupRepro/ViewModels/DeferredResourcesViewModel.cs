using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace WpfDeferredResourceLookupRepro.ViewModels
{
    public class DeferredResourcesViewModel : ViewModel
    {
        private int _deferredResourceCount;
        private TimeSpan _operationTime;
        private MainViewModel _mainViewModel;

        public DeferredResourcesViewModel()
        {
            AddTabsCommand = new RelayCommand(
                () =>
                {
                    _ = TimeAsync(() => _mainViewModel?.AddTabs());
                    ((RelayCommand)RemoveTabsCommand).CanExecute = true;
                    ((RelayCommand)AddTabsCommand).CanExecute = false;
                });

            RemoveTabsCommand = new RelayCommand(
                () =>
                {
                    _ = TimeAsync(() => _mainViewModel?.RemoveTabs());
                    ((RelayCommand)RemoveTabsCommand).CanExecute = false;
                    ((RelayCommand)AddTabsCommand).CanExecute = true;
                })
                {
                    CanExecute = false
                };
        }

        public int DeferredResourceCount
        {
            get => _deferredResourceCount;
            set => Set(ref _deferredResourceCount, value);
        }

        public TimeSpan OperationTime
        {
            get => _operationTime;
            set => Set(ref _operationTime, value);
        }

        public ICommand AddTabsCommand { get; }

        public ICommand RemoveTabsCommand { get; }

        public void Initialize(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            _ = UpdateCountAsync();
        }

        private async Task UpdateCountAsync()
        {
            while (true)
            {
                var res = await Task.Run(() => DeferredResourceInfo.GetDeferredResourceInfos().ToList());
                DeferredResourceCount = res.Count;

                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }

        private async Task TimeAsync(Action operation)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            operation();

            await Dispatcher.Yield(DispatcherPriority.Background);

            sw.Stop();
            OperationTime = sw.Elapsed;
        }
    }
}
