using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    public class Program
    {
        [System.STAThreadAttribute()]
        public static void Main()
        {
            using (new SampleApp.XamlIslandApp.App())
            {
                var app = new SampleApp.App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
