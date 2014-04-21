using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_03
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.IO.StreamWriter sw=new StreamWriter("users.txt");
            sw.WriteLine(textBox1.Text);
            sw.Close();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StreamReader sr=new StreamReader("users.txt");
            label1.Content = "Hello " + sr.ReadToEnd();
            sr.Close();
        }
    }
}
