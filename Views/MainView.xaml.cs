using System;
using System.Windows.Controls;
using WpfDeferredResourceLookupRepo.ViewModels;

namespace WpfDeferredResourceLookupRepo.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            ((MainViewModel)DataContext)?.Initialize();
        }
    }
}
