using System;
using System.Collections.Generic;
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


namespace wpf_07
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
   // public static readonly RoutedEvent sClickEvent;

    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e) {
            MessageBox.Show("Event raised by TextBox");
            e.Handled = (bool)radioButton1.IsChecked;

        }

        private void Grid_TextChanged(object sender, TextChangedEventArgs e) {
            MessageBox.Show("Event raised by grid");
            e.Handled = (bool)radioButton2.IsChecked;
        }

        private void Window_TextChanged(object sender, TextChangedEventArgs e) {
            MessageBox.Show("Event raised by window");
            e.Handled = (bool)radioButton3.IsChecked;
        }

        private void Grid_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("out Grid");

        }

        private void Window_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("out window");

        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("button/ yes/ is first ");
        }
    }
}
