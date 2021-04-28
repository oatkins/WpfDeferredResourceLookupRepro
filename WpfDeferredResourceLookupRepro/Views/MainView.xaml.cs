using System;
using System.Windows.Controls;
using WpfDeferredResourceLookupRepro.ViewModels;

namespace WpfDeferredResourceLookupRepro.Views
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
