using ConvMVVM2.WPF.Host;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LabelTool
{
    public class Starter
    {

        #region Public Functions
        [STAThread]
        public static void Main(string[] args)
        {
            var host = ConvMVVM2Host.CreateHost<BootStrapper, Application>(args, "LabelTool");
            host.Build()
                .Popup("MainWindow", dialog: true)
                .RunApp();

        }
        #endregion
    }
}
