using System;
using System.Windows.Media;
using XamlIslandSample.Models;

namespace XamlIslandSample.Contracts.Services
{
    public interface IThemeSelectorService
    {
        event EventHandler ThemeChanged;

        bool SetTheme(AppTheme? theme = null);

        AppTheme GetCurrentTheme();

        SolidColorBrush GetColor(string colorKey);
    }
}
