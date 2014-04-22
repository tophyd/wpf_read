using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace wpf_01p
{
    class main
    {
        [STAThread]
        public static void Main()
        {
            var win=new Window {Title = "Say Hello"};
            win.Show();

            var app=new Application();
            app.Run();
        }
    }
}
