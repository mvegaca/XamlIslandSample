using XamlIslandSample.Models;

namespace XamlIslandSample.Contracts.Services
{
    public interface IThemeSelectorService
    {
        bool SetTheme(AppTheme? theme = null);

        AppTheme GetCurrentTheme();

        AppColors GetAppColors();
    }
}
