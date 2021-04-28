using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfDeferredResourceLookupRepro.Controls
{
    public sealed partial class Widget
    {
        public static readonly DependencyProperty Toggle1Property =
            DependencyProperty.Register("Toggle1",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle1
        {
            get => (bool)GetValue(Toggle1Property);
            set => SetValue(Toggle1Property, value);
        }

        public static readonly DependencyProperty Toggle2Property =
            DependencyProperty.Register("Toggle2",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle2
        {
            get => (bool)GetValue(Toggle2Property);
            set => SetValue(Toggle2Property, value);
        }

        public static readonly DependencyProperty Toggle3Property =
            DependencyProperty.Register("Toggle3",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle3
        {
            get => (bool)GetValue(Toggle3Property);
            set => SetValue(Toggle3Property, value);
        }

        public static readonly DependencyProperty Toggle4Property =
            DependencyProperty.Register("Toggle4",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle4
        {
            get => (bool)GetValue(Toggle4Property);
            set => SetValue(Toggle4Property, value);
        }

        public static readonly DependencyProperty Toggle5Property =
            DependencyProperty.Register("Toggle5",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle5
        {
            get => (bool)GetValue(Toggle5Property);
            set => SetValue(Toggle5Property, value);
        }

        public static readonly DependencyProperty Toggle6Property =
            DependencyProperty.Register("Toggle6",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle6
        {
            get => (bool)GetValue(Toggle6Property);
            set => SetValue(Toggle6Property, value);
        }

        public static readonly DependencyProperty Toggle7Property =
            DependencyProperty.Register("Toggle7",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle7
        {
            get => (bool)GetValue(Toggle7Property);
            set => SetValue(Toggle7Property, value);
        }

        public static readonly DependencyProperty Toggle8Property =
            DependencyProperty.Register("Toggle8",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle8
        {
            get => (bool)GetValue(Toggle8Property);
            set => SetValue(Toggle8Property, value);
        }

        public static readonly DependencyProperty Toggle9Property =
            DependencyProperty.Register("Toggle9",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle9
        {
            get => (bool)GetValue(Toggle9Property);
            set => SetValue(Toggle9Property, value);
        }

        public static readonly DependencyProperty Toggle10Property =
            DependencyProperty.Register("Toggle10",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle10
        {
            get => (bool)GetValue(Toggle10Property);
            set => SetValue(Toggle10Property, value);
        }

        public static readonly DependencyProperty Toggle11Property =
            DependencyProperty.Register("Toggle11",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle11
        {
            get => (bool)GetValue(Toggle11Property);
            set => SetValue(Toggle11Property, value);
        }

        public static readonly DependencyProperty Toggle12Property =
            DependencyProperty.Register("Toggle12",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle12
        {
            get => (bool)GetValue(Toggle12Property);
            set => SetValue(Toggle12Property, value);
        }

        public static readonly DependencyProperty Toggle13Property =
            DependencyProperty.Register("Toggle13",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle13
        {
            get => (bool)GetValue(Toggle13Property);
            set => SetValue(Toggle13Property, value);
        }

        public static readonly DependencyProperty Toggle14Property =
            DependencyProperty.Register("Toggle14",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle14
        {
            get => (bool)GetValue(Toggle14Property);
            set => SetValue(Toggle14Property, value);
        }

        public static readonly DependencyProperty Toggle15Property =
            DependencyProperty.Register("Toggle15",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle15
        {
            get => (bool)GetValue(Toggle15Property);
            set => SetValue(Toggle15Property, value);
        }

        public static readonly DependencyProperty Toggle16Property =
            DependencyProperty.Register("Toggle16",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle16
        {
            get => (bool)GetValue(Toggle16Property);
            set => SetValue(Toggle16Property, value);
        }

        public static readonly DependencyProperty Toggle17Property =
            DependencyProperty.Register("Toggle17",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle17
        {
            get => (bool)GetValue(Toggle17Property);
            set => SetValue(Toggle17Property, value);
        }

        public static readonly DependencyProperty Toggle18Property =
            DependencyProperty.Register("Toggle18",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle18
        {
            get => (bool)GetValue(Toggle18Property);
            set => SetValue(Toggle18Property, value);
        }

        public static readonly DependencyProperty Toggle19Property =
            DependencyProperty.Register("Toggle19",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle19
        {
            get => (bool)GetValue(Toggle19Property);
            set => SetValue(Toggle19Property, value);
        }

        public static readonly DependencyProperty Toggle20Property =
            DependencyProperty.Register("Toggle20",
                typeof(Brush),
                typeof(Widget),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool Toggle20
        {
            get => (bool)GetValue(Toggle20Property);
            set => SetValue(Toggle20Property, value);
        }

    }
}
