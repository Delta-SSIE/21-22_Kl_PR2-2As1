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

namespace _03_WPF_03_MessageBox
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Zformátujeme disk C:", "Varování", MessageBoxButton.YesNoCancel, MessageBoxImage.Information);

            switch (result)
            {
                //case MessageBoxResult.None:
                //    break;
                //case MessageBoxResult.OK:
                //    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Tak co teda?");
                    break;
                case MessageBoxResult.Yes:
                    MessageBox.Show("Mažu, kdo maže, ten jede!");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Nemažu, skřípu.");
                    break;
                default:
                    break;
            }
        }
    }
}
