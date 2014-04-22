using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace wpf_01p
{
    class main
    {
        [STAThread]
        public static void Main()
        {
            var win=new Window {Title = "Say Hello"};
            win.Show();
            win.MouseDown += WindowOnMouseDown;

            var app=new Application();
            app.Run();
        }

        private static void WindowOnMouseDown(object sender, MouseButtonEventArgs e)
        {
            //throw new NotImplementedException();
            Window win = sender as Window;
            string strMessage = string.Format("Window clicked {0} button at point {1}", e.ChangedButton, e.GetPosition(win));
            MessageBox.Show(strMessage, win.Title);

        }
    }
}
