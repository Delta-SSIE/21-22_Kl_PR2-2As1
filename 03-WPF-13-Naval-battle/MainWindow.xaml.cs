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

namespace _03_WPF_13_Naval_battle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int _seaSize = 10;
        private const int _shipCount = 12;

        private Player _player;
        private Player _computer;

        public MainWindow()
        {
            InitializeComponent();

            _player = new Player(_shipCount, _seaSize);
            _computer = new Player(_shipCount, _seaSize);           

            //inicializovat oba displeje
            InitializeSeaDisplay(PlayerSeaDisplay, _player.GetPrivateSea());
            InitializeSeaDisplay(ComputerSeaDisplay, _computer.GetPublicSea());

            //inicializovat počítadla
            RenderHitsDisplay(PlayerHitsDisplay, _player.WrecksCount);
            RenderHitsDisplay(ComputerHitsDisplay, _computer.WrecksCount);
        }

        private void InitializeSeaDisplay(Grid display, TileState[,] sea)
        {
            for (int i = 0; i < _seaSize; i++)
            {
                display.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < _seaSize; i++)
            {
                display.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int x = 0; x < _seaSize; x++)
            {
                for (int y = 0; y < _seaSize; y++)
                {
                    Rectangle tile = new Rectangle();

                    RenderTile(tile, sea[x, y]);

                    tile.MouseDown += Tile_MouseDown;

                    Grid.SetRow(tile, y);
                    Grid.SetColumn(tile, x);

                    display.Children.Add(tile);
                }
            }
        }

        private void Tile_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Když hráč klikne

            //zjistím stav cíle

            //když je tam loď (apod)
            //změním na vrak ...

            //vykreslím výsledek střely

            //když počítači dojdou lodě
            //ohlásím vítězství a skončím
        }

        private void RenderTile(Rectangle tile, TileState state)
        {
            switch (state)
            {
                case TileState.Empty:
                    tile.Style = FindResource("EmptyTile") as Style;
                    break;
                case TileState.Ship:
                    tile.Style = FindResource("ShipTile") as Style;
                    break;
                case TileState.Wreck:
                    tile.Style = FindResource("WreckTile") as Style;
                    break;
                case TileState.Missed:
                    tile.Style = FindResource("MissedTile") as Style;
                    break;
            }
        }

        private void RenderHitsDisplay(Label display, int hits)
        {
            display.Content = $"{hits} / {_shipCount}";
        }
    }
}
