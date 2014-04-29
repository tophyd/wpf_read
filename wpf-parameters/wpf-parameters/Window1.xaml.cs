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
using wpf_parameters.Properties;

namespace wpf_parameters {
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            Title = Properties.Settings.Default.ApplicationName;
            Background =new SolidColorBrush(Properties.Settings.Default.BackgroundColor);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if (ListBox1.SelectedItem != null)
            {
                String astring = ((ListBoxItem) ListBox1.SelectedItem).Content.ToString();
                switch (astring)
                {
                    case "Red":
                        Settings.Default.BackgroundColor = Colors.Red;
                        break;
                    case "Blue":
                        Settings.Default.BackgroundColor = Colors.Blue;
                        break;
                    case "Green":
                        Settings.Default.BackgroundColor = Colors.Green;
                        break;
                    case "Tomato":
                        Settings.Default.BackgroundColor = Colors.Tomato;
                        break;
                }
                Background = new SolidColorBrush(Settings.Default.BackgroundColor);
                Settings.Default.Save();
            }


        
            }
        }
    }

