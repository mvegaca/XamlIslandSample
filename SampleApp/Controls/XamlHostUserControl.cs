using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Extensions.Hosting;
using SampleApp.Contracts.Services;
using SampleApp.Models;
using SampleApp.XamlIsland;

namespace SampleApp.Controls
{
    public class XamlHostUserControl : UserControl
    {
        private XamlIslandUserControl _xamlIsland;
        private readonly IThemeSelectorService _themeSelectorService;
        private IHost _host => ((App)App.Current).ApplicationHost;
        private bool _useDarkTheme;
        private SolidColorBrush _backgroundColor;

        public XamlHostUserControl()
        {
            _themeSelectorService = _host.Services.GetService(typeof(IThemeSelectorService)) as IThemeSelectorService;
            _themeSelectorService.ThemeChanged += OnThemeChanged;
            GetColors();
        }

        private void OnThemeChanged(object sender, System.EventArgs e)
        {
            GetColors();
            ApplyColors();
        }

        protected void BindCommonProperties(XamlIslandUserControl xamlIsland)
        {
            _xamlIsland = xamlIsland;
            ApplyColors();
        }

        private void GetColors()
        {
            _backgroundColor = _themeSelectorService.GetColor("MahApps.Brushes.Control.Background");
            _useDarkTheme = _themeSelectorService.GetCurrentTheme() == AppTheme.Dark;
        }

        private void ApplyColors()
        {
            _xamlIsland.BackgroundColor = Converters.ColorConverter.FromSystemColor(_backgroundColor);
            _xamlIsland.UseDarkTheme = _useDarkTheme;
        }
    }
}
