using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace XamlIslandSample.XamlIsland
{
    public class XamlIslandUserControl : UserControl
    {
        public static readonly DependencyProperty BackgroundColorProperty = DependencyProperty.Register(nameof(BackgroundColor), typeof(Brush), typeof(XamlIslandUserControl), new PropertyMetadata(null));
        public static readonly DependencyProperty TextColorProperty = DependencyProperty.Register(nameof(TextColor), typeof(Brush), typeof(XamlIslandUserControl), new PropertyMetadata(null));

        public Brush BackgroundColor
        {
            get { return (Brush)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }        

        public Brush TextColor
        {
            get { return (Brush)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }
    }
}
