using System;
using System.Windows.Media;
using WUXD = Windows.UI.Xaml.Data;
using WUXM = Windows.UI.Xaml.Media;

namespace XamlIslandSample.Converters
{
    public class ColorConverter : WUXD.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is SolidColorBrush brush)
            {
                return FromSystemColor(brush);
            }

            return default;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is WUXM.SolidColorBrush brush)
            {
                return FromWindowsColor(brush);
            }

            return default;
        }

        public static WUXM.SolidColorBrush FromSystemColor(SolidColorBrush brush)
            => new WUXM.SolidColorBrush(new Windows.UI.Color()
            {
                A = brush.Color.A,
                R = brush.Color.R,
                G = brush.Color.G,
                B = brush.Color.B
            });

        public static SolidColorBrush FromWindowsColor(WUXM.SolidColorBrush brush)
            => new SolidColorBrush(new Color()
            {
                A = brush.Color.A,
                R = brush.Color.R,
                G = brush.Color.G,
                B = brush.Color.B
            });

        //public static SolidColorBrush FromARGB(string code)
        //{
        //    code = code.Replace("#", "");
        //    var a = byte.Parse(code.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
        //    var r = byte.Parse(code.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
        //    var g = byte.Parse(code.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        //    var b = byte.Parse(code.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
        //    return new SolidColorBrush(Color.FromArgb(a, r, g, b));
        //}
    }
}
