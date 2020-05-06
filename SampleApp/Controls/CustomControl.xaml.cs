

using System;
using System.Windows;
using Microsoft.Toolkit.Wpf.UI.XamlHost;
using SampleApp.XamlIsland;

using WUX = Windows.UI.Xaml;
using WUXD = Windows.UI.Xaml.Data;

namespace SampleApp.Controls
{
    // For info about hosting a custom UWP control in a WPF app using XAML Islands read this doc
    // https://docs.microsoft.com/en-us/windows/apps/desktop/modernize/host-custom-control-with-xaml-islands
    public partial class CustomControl : XamlHostUserControl
    {
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(CustomControl), new PropertyMetadata(string.Empty, (d, a) => { }));        

        public CustomControl()
        {
            InitializeComponent();
        }

        private void OnChildChanged(object sender, EventArgs e)
        {
            if (sender is WindowsXamlHost host && host.GetUwpInternalObject() is XamlIslandUserControl xamlIsland)
            {
                BindCommonProperties(xamlIsland);
                xamlIsland.SetBinding(CustomControlUniversal.TextProperty, new WUXD.Binding() { Path = new WUX.PropertyPath(nameof(Text)), Mode = WUXD.BindingMode.TwoWay });
            }
        }
    }
}
