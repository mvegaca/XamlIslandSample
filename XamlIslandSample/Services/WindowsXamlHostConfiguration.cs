using System;
using System.Collections.Generic;
using Microsoft.Toolkit.Wpf.UI.XamlHost;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace XamlIslandSample.Services
{
    public class WindowsXamlHostConfiguration
    {
        public string Key { get; set; }

        public WindowsXamlHost Host { get; set; }

        public Dictionary<DependencyProperty, BindingBase> Bindings { get; set; }

        public WindowsXamlHostConfiguration(string key, WindowsXamlHost host, Dictionary<DependencyProperty, BindingBase> bindings)
        {
            Key = key;
            Host = host;
            Bindings = bindings;
            Host.ChildChanged += OnChildChanged;
        }

        private void OnChildChanged(object sender, EventArgs e)
        {
            if (Host.GetUwpInternalObject() is UserControl userControl)
            {
                foreach (var binding in Bindings)
                {
                    userControl.SetBinding(binding.Key, binding.Value);
                }
            }
        }
    }
}
