using System;
using System.Windows.Media;
using SampleApp.Models;

namespace SampleApp.Contracts.Services
{
    public interface IThemeSelectorService
    {
        event EventHandler ThemeChanged;

        bool SetTheme(AppTheme? theme = null);

        AppTheme GetCurrentTheme();

        SolidColorBrush GetColor(string colorKey);
    }
}
