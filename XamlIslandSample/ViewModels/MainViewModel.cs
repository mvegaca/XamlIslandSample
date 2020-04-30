using System;
using XamlIslandSample.Contracts.Services;
using XamlIslandSample.Helpers;
using XamlIslandSample.Models;

namespace XamlIslandSample.ViewModels
{
    public class MainViewModel : Observable
    {
        private readonly System.Windows.Threading.DispatcherTimer _dt;
        private readonly IThemeSelectorService _themeSelectorService;

        private string _text;        
        private AppColors _appColors;

        public string Text
        {
            get { return _text; }
            set { Set(ref _text, value); }
        }

        public AppColors AppColors
        {
            get { return _appColors; }
            set { Set(ref _appColors, value); }
        }

        public MainViewModel(IThemeSelectorService themeSelectorService)
        {
            _themeSelectorService = themeSelectorService;
            _dt = new System.Windows.Threading.DispatcherTimer();
            _dt.Interval = TimeSpan.FromSeconds(1);
            _dt.Tick += OnTick;
            _dt.Start();
            AppColors = _themeSelectorService.GetAppColors();
        }

        private void OnTick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
