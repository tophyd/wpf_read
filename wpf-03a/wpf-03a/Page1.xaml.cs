using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
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

namespace wpf_03a
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void SetName_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFileStream fs=new IsolatedStorageFileStream("users.txt", FileMode.Create);

            
            StreamWriter sw=new StreamWriter(fs);
            sw.WriteLine(textBox.Text);
            sw.Close();
        }

        private void GetName_Click(object sender, RoutedEventArgs e)
        {

            IsolatedStorageFileStream fs = new IsolatedStorageFileStream("users.txt", FileMode.OpenOrCreate);

            var sr = new StreamReader(fs);
            label.Content = "Hello " + sr.ReadToEnd();
            sr.Close();
        }
    }
}
