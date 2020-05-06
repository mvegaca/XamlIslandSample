using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace SampleApp.XamlIsland
{
    public class XamlIslandUserControl : UserControl
    {
        public Brush BackgroundColor
        {
            get { return (Brush)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }

        public bool UseDarkTheme
        {
            get { return (bool)GetValue(UseDarkThemeProperty); }
            set { SetValue(UseDarkThemeProperty, value); }
        }

        public static readonly DependencyProperty BackgroundColorProperty = DependencyProperty.Register(nameof(BackgroundColor), typeof(Brush), typeof(XamlIslandUserControl), new PropertyMetadata(null, (d, e) => { }));

        public static readonly DependencyProperty UseDarkThemeProperty = DependencyProperty.Register(nameof(UseDarkTheme), typeof(bool), typeof(XamlIslandUserControl), new PropertyMetadata(false, OnUseDarkThemePropertyChanged));

        private static void OnUseDarkThemePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is XamlIslandUserControl control && e.NewValue is bool useDarkTheme)
            {
                control.RequestedTheme = useDarkTheme ? ElementTheme.Dark : ElementTheme.Light;
            }
        }
    }
}