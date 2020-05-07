using System.Windows.Controls;
using SampleApp.ViewModels;

namespace SampleApp.Views
{
    public partial class XamlIslandPage : Page
    {
        public XamlIslandPage(XamlIslandViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
