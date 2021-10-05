using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        int level = 1;
        public int Level { get { return level; } }

        public Settings()
        {
            InitializeComponent();
        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            if (RadioButton1.IsChecked == true) { level = 1; }
            if (RadioButton2.IsChecked == true) { level = 2; }
            if (RadioButton3.IsChecked == true) { level = 3; }
            this.DialogResult = true;
        }
    }
}
