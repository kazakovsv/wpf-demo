using System.Windows;
using System.Windows.Controls;

namespace Demo01_Transformations
{
    public partial class RangeBox : UserControl
    {
        public static readonly DependencyProperty LabelContentProperty =
            DependencyProperty.Register(
                "LabelContent",
                typeof(object),
                typeof(RangeBox),
                new PropertyMetadata(null));

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(
                "Value",
                typeof(double),
                typeof(RangeBox),
                new PropertyMetadata(0D));

        public RangeBox()
        {
            InitializeComponent();
        }

        public object LabelContent
        {
            get => GetValue(LabelContentProperty);
            set => SetValue(LabelContentProperty, value);
        }

        public double Value
        {
            get => (double)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }
    }
}
