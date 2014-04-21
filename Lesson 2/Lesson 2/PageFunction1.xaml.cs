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
    public partial class PageFunction1 : PageFunction<String>
    {
        public PageFunction1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem l = (ListBoxItem)listBox1.SelectedItem;
            listBox1.Items.Remove(l);
            listBox2.Items.Add(l);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem l = (ListBoxItem)listBox2.SelectedItem;
            listBox2.Items.Remove(l);
            listBox1.Items.Add(l);
        }
    }
}
