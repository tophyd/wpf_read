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

namespace Lesson_2
{
    /// <summary>
    /// Interaction logic for PageFunction1.xaml
    /// </summary>
    public partial class PageFunction1 : PageFunction<Object>
    {
        public PageFunction1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem l = (ListBoxItem)ListBox1.SelectedItem;
            ListBox1.Items.Remove(l);
            ListBox2.Items.Add(l);
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem l = (ListBoxItem)ListBox2.SelectedItem;
            ListBox2.Items.Remove(l);
            ListBox1.Items.Add(l);
        }
    }
}
