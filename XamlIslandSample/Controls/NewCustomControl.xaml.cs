

using System;
using System.Windows;
using Microsoft.Toolkit.Wpf.UI.XamlHost;
using XamlIslandSample.XamlIsland;

using WUX = Windows.UI.Xaml;
using WUXD = Windows.UI.Xaml.Data;

namespace XamlIslandSample.Controls
{
    public partial class NewCustomControl : XamlHostUserControl
    {
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(NewCustomControl), new PropertyMetadata(string.Empty));        

        public NewCustomControl()
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
