using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace XamlIslandSample.XamlIsland
{
    public sealed partial class CustomControlUniversal : XamlIslandUserControl
    {
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(CustomControlUniversal), new PropertyMetadata(string.Empty));

        public CustomControlUniversal()
        {
            this.InitializeComponent();
        }
    }
}
