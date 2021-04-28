using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfDeferredResourceLookupRepro.Controls
{
    public sealed partial class ItemProperties
    {
        public static readonly DependencyProperty ItemBrush1Property =
            DependencyProperty.RegisterAttached("ItemBrush1",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush1(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush1Property);

        public static void SetItemBrush1(ListViewItem obj, object value) => obj.SetValue(ItemBrush1Property, value);

        public static readonly DependencyProperty ItemBrush2Property =
            DependencyProperty.RegisterAttached("ItemBrush2",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush2(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush2Property);

        public static void SetItemBrush2(ListViewItem obj, object value) => obj.SetValue(ItemBrush2Property, value);

        public static readonly DependencyProperty ItemBrush3Property =
            DependencyProperty.RegisterAttached("ItemBrush3",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush3(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush3Property);

        public static void SetItemBrush3(ListViewItem obj, object value) => obj.SetValue(ItemBrush3Property, value);

        public static readonly DependencyProperty ItemBrush4Property =
            DependencyProperty.RegisterAttached("ItemBrush4",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush4(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush4Property);

        public static void SetItemBrush4(ListViewItem obj, object value) => obj.SetValue(ItemBrush4Property, value);

        public static readonly DependencyProperty ItemBrush5Property =
            DependencyProperty.RegisterAttached("ItemBrush5",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush5(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush5Property);

        public static void SetItemBrush5(ListViewItem obj, object value) => obj.SetValue(ItemBrush5Property, value);

        public static readonly DependencyProperty ItemBrush6Property =
            DependencyProperty.RegisterAttached("ItemBrush6",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush6(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush6Property);

        public static void SetItemBrush6(ListViewItem obj, object value) => obj.SetValue(ItemBrush6Property, value);

        public static readonly DependencyProperty ItemBrush7Property =
            DependencyProperty.RegisterAttached("ItemBrush7",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush7(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush7Property);

        public static void SetItemBrush7(ListViewItem obj, object value) => obj.SetValue(ItemBrush7Property, value);

        public static readonly DependencyProperty ItemBrush8Property =
            DependencyProperty.RegisterAttached("ItemBrush8",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush8(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush8Property);

        public static void SetItemBrush8(ListViewItem obj, object value) => obj.SetValue(ItemBrush8Property, value);

        public static readonly DependencyProperty ItemBrush9Property =
            DependencyProperty.RegisterAttached("ItemBrush9",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush9(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush9Property);

        public static void SetItemBrush9(ListViewItem obj, object value) => obj.SetValue(ItemBrush9Property, value);

        public static readonly DependencyProperty ItemBrush10Property =
            DependencyProperty.RegisterAttached("ItemBrush10",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush10(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush10Property);

        public static void SetItemBrush10(ListViewItem obj, object value) => obj.SetValue(ItemBrush10Property, value);

        public static readonly DependencyProperty ItemBrush11Property =
            DependencyProperty.RegisterAttached("ItemBrush11",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush11(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush11Property);

        public static void SetItemBrush11(ListViewItem obj, object value) => obj.SetValue(ItemBrush11Property, value);

        public static readonly DependencyProperty ItemBrush12Property =
            DependencyProperty.RegisterAttached("ItemBrush12",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush12(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush12Property);

        public static void SetItemBrush12(ListViewItem obj, object value) => obj.SetValue(ItemBrush12Property, value);

        public static readonly DependencyProperty ItemBrush13Property =
            DependencyProperty.RegisterAttached("ItemBrush13",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush13(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush13Property);

        public static void SetItemBrush13(ListViewItem obj, object value) => obj.SetValue(ItemBrush13Property, value);

        public static readonly DependencyProperty ItemBrush14Property =
            DependencyProperty.RegisterAttached("ItemBrush14",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush14(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush14Property);

        public static void SetItemBrush14(ListViewItem obj, object value) => obj.SetValue(ItemBrush14Property, value);

        public static readonly DependencyProperty ItemBrush15Property =
            DependencyProperty.RegisterAttached("ItemBrush15",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush15(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush15Property);

        public static void SetItemBrush15(ListViewItem obj, object value) => obj.SetValue(ItemBrush15Property, value);

        public static readonly DependencyProperty ItemBrush16Property =
            DependencyProperty.RegisterAttached("ItemBrush16",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush16(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush16Property);

        public static void SetItemBrush16(ListViewItem obj, object value) => obj.SetValue(ItemBrush16Property, value);

        public static readonly DependencyProperty ItemBrush17Property =
            DependencyProperty.RegisterAttached("ItemBrush17",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush17(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush17Property);

        public static void SetItemBrush17(ListViewItem obj, object value) => obj.SetValue(ItemBrush17Property, value);

        public static readonly DependencyProperty ItemBrush18Property =
            DependencyProperty.RegisterAttached("ItemBrush18",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush18(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush18Property);

        public static void SetItemBrush18(ListViewItem obj, object value) => obj.SetValue(ItemBrush18Property, value);

        public static readonly DependencyProperty ItemBrush19Property =
            DependencyProperty.RegisterAttached("ItemBrush19",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush19(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush19Property);

        public static void SetItemBrush19(ListViewItem obj, object value) => obj.SetValue(ItemBrush19Property, value);

        public static readonly DependencyProperty ItemBrush20Property =
            DependencyProperty.RegisterAttached("ItemBrush20",
                typeof(Brush),
                typeof(ItemProperties),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static Brush GetItemBrush20(ListViewItem obj) => (Brush)obj.GetValue(ItemBrush20Property);

        public static void SetItemBrush20(ListViewItem obj, object value) => obj.SetValue(ItemBrush20Property, value);

    }
}
