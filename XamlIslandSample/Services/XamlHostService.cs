using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Toolkit.Wpf.UI.XamlHost;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using XamlIslandSample.Contracts.Services;

namespace XamlIslandSample.Services
{
    public class XamlHostService : IXamlHostService
    {
        private readonly List<WindowsXamlHostConfiguration> _hosts = new List<WindowsXamlHostConfiguration>();

        public XamlHostService()
        {
        }

        public void Configure(WindowsXamlHostConfiguration configuration)
        {
            _hosts.Add(configuration);
        }
    }
}
