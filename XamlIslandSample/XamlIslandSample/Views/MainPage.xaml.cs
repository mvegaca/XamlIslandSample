using System.Windows.Controls;

using XamlIslandSample.ViewModels;

namespace XamlIslandSample.Views
{
    public partial class MainPage : Page
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
