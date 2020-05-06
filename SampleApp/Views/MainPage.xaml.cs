using System.Windows.Controls;
using SampleApp.ViewModels;

namespace SampleApp.Views
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
