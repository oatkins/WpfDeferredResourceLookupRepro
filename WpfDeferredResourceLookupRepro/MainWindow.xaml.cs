using System;
using System.Windows;
using WpfDeferredResourceLookupRepro.ViewModels;

namespace WpfDeferredResourceLookupRepro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            var mainViewModel = (MainViewModel)MainViewControl?.DataContext;
            var deferredResourcesViewModel = (DeferredResourcesViewModel)DeferredResourcesViewControl?.DataContext;

            mainViewModel?.Initialize();
            deferredResourcesViewModel?.Initialize(mainViewModel);
        }
    }
}
