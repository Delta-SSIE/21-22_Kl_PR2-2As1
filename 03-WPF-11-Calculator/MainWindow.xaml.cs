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

namespace _03_WPF_11_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //uložená data
        //aktuální stav displeje
        private string currentText = "0";

        //minulá vložená hodnota
        private double lastValue = 0;

        //zvolená operace
        private SimpleMath.Operation operation;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void NumberBtn_Click(object sender, RoutedEventArgs e)
        {
            //odkaz na tlačítko, které bylo stisknuto
            Button pressed = (Button)sender;

            //vytáhnu číslici tlačítka
            string symbol = pressed.Content.ToString();

            //vezmi, co je na displeji
            if (currentText == "0")
            {
                currentText = "";
            }

            //přidej za to stisknutou číslici
            currentText += symbol;

            //zobraz
            Render();
        }

        private void Render()
        {
            Display.Text = currentText;
        }

        private void ACBtn_Click(object sender, RoutedEventArgs e)
        {
            currentText = "0";
            Render();
        }

        private void PlusMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (currentText == "0") //nule nebudu obracet znaménko
            {
                return;
            }

            //zjistíme, jestli je první znak "-"
            char first = currentText[0];

            if (first != '-') //když není na začítku mínus
            { 
                currentText = "-" + currentText; //přidej na začátek -
            }
            else
            {
                currentText = currentText.Substring(1); //zahoď první znak
            }

            //jiný zápis - převod na číslo a zpět na řetězec
            //currentText = Convert.ToString(double.Parse(currentText) * -1);

            Render();
        }
    }
}
