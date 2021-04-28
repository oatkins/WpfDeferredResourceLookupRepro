using System.Windows;
using System.Windows.Controls;

namespace WpfDeferredResourceLookupRepro.Controls
{
    public partial class Widget : ContentControl
    {
        static Widget()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Widget), new FrameworkPropertyMetadata(typeof(Widget)));
        }
    }
}
