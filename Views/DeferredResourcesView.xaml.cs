using System;
using System.Windows.Controls;
using WpfDeferredResourceLookupRepo.ViewModels;

namespace WpfDeferredResourceLookupRepo.Views
{
    /// <summary>
    /// Interaction logic for DeferredResourcesView.xaml
    /// </summary>
    public partial class DeferredResourcesView : UserControl
    {
        public DeferredResourcesView()
        {
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            ((DeferredResourcesViewModel)DataContext)?.Initialize();
        }
    }
}
