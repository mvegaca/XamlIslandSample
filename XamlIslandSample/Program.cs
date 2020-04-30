using System;
using System.Collections.Generic;
using System.Text;

namespace XamlIslandSample
{
    public class Program
    {
        [System.STAThreadAttribute()]
        public static void Main()
        {
            using (new XamlIslandSample.XamlIslandApp.App())
            {
                var app = new XamlIslandSample.App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
