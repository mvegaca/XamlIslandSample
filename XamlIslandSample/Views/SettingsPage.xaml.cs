using System.Windows.Controls;

using XamlIslandSample.ViewModels;

namespace XamlIslandSample.Views
{
    public partial class SettingsPage : Page
    {
        public SettingsPage(SettingsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
