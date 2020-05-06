using Windows.UI.Xaml;

namespace SampleApp.XamlIsland
{
    public sealed partial class CustomControlUniversal : XamlIslandUserControl
    {
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(CustomControlUniversal), new PropertyMetadata(string.Empty, (d, e) => { }));

        public CustomControlUniversal()
        {
            this.InitializeComponent();
        }
    }
}
