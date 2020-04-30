using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using XamlIslandSample.Converters;
using XamlIslandSample.Models;
using XamlIslandSample.XamlIsland;
using WUX = Windows.UI.Xaml;
using WUXD = Windows.UI.Xaml.Data;

namespace XamlIslandSample.Controls
{
    public class XamlHostUserControl : UserControl
    {
        public static readonly DependencyProperty AppColorsProperty = DependencyProperty.Register(nameof(AppColors), typeof(AppColors), typeof(XamlHostUserControl), new PropertyMetadata(null));        

        public AppColors AppColors
        {
            get { return (AppColors)GetValue(AppColorsProperty); }
            set { SetValue(AppColorsProperty, value); }
        }

        protected void BindCommonProperties(WUX.FrameworkElement element)
        {
            element.SetBinding(XamlIslandUserControl.BackgroundColorProperty, new WUXD.Binding() { Path = new WUX.PropertyPath("AppColors.BackgroundColor"), Converter = new UwpColorConverter() });
            element.SetBinding(XamlIslandUserControl.TextColorProperty, new WUXD.Binding() { Path = new WUX.PropertyPath("AppColors.TextColor"), Converter = new UwpColorConverter() });
        }
    }
}
