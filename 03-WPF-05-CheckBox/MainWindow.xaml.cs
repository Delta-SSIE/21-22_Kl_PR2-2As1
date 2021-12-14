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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _03_WPF_05_CheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            AddFeeCB.IsChecked = true;
        }

        private void UncheckBtn_Click(object sender, RoutedEventArgs e)
        {
            AddFeeCB.IsChecked = false;
        }

        private void AddFeeCB_CheckedChanged(object sender, RoutedEventArgs e)
        {
            DisplayRect.Fill = AddFeeCB.IsChecked == true ? Brushes.Gold : Brushes.Green;
        }
    }
}
