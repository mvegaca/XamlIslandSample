using System;
using System.Windows.Media;
using WUXD = Windows.UI.Xaml.Data;
using WUXM = Windows.UI.Xaml.Media;

namespace XamlIslandSample.Converters
{
    public class UwpColorConverter : WUXD.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is SolidColorBrush brush)
            {
                return new WUXM.SolidColorBrush(new Windows.UI.Color()
                {
                    A = brush.Color.A,
                    R = brush.Color.R,
                    G = brush.Color.G,
                    B = brush.Color.B
                });
            }

            return default;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is WUXM.SolidColorBrush brush)
            {
                return new SolidColorBrush(new Color()
                {
                    A = brush.Color.A,
                    R = brush.Color.R,
                    G = brush.Color.G,
                    B = brush.Color.B
                });
            }

            return default;
        }
    }
}
