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
using System.Windows.Threading;

namespace _03_WPF_13_Naval_battle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int _seaSize = 3;
        private const int _shipCount = 4;
        private const int _shotWait = 1000; //milliseconds to wait before computer shooting

        private Player _player;
        private Player _computer;

        private Rectangle[,] _playerTiles;
        private DispatcherTimer _shotTimer;

        private bool _playerCanShoot;

        public MainWindow()
        {
            InitializeComponent();

            _player = new Player(_shipCount, _seaSize);
            _computer = new Player(_shipCount, _seaSize);           

            //inicializovat oba displeje
            InitializeSeaDisplay(PlayerSeaDisplay, _player.GetPrivateSea());
            InitializeSeaDisplay(ComputerSeaDisplay, _computer.GetPublicSea(), true);

            //inicializovat počítadla
            RenderHitsDisplay(PlayerHitsDisplay, _player.WrecksCount);
            RenderHitsDisplay(ComputerHitsDisplay, _computer.WrecksCount);

            _shotTimer = new DispatcherTimer();
            _shotTimer.Interval = TimeSpan.FromMilliseconds(_shotWait);
            _shotTimer.Tick += _shotTimer_Tick;

            _playerCanShoot = true;
        }

        private void _shotTimer_Tick(object sender, EventArgs e)
        {
            _shotTimer.Stop();
            ComputerMove();
        }

        private void InitializeSeaDisplay(Grid display, TileState[,] sea, bool isClickable = false)
        {
            for (int i = 0; i < _seaSize; i++)
            {
                display.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < _seaSize; i++)
            {
                display.ColumnDefinitions.Add(new ColumnDefinition());
            }
            
            if (!isClickable)
                _playerTiles = new Rectangle[_seaSize, _seaSize]; //uložím si mapu, kde který rectangle je
            
            for (int x = 0; x < _seaSize; x++)
            {
                for (int y = 0; y < _seaSize; y++)
                {
                    Rectangle tile = new Rectangle();

                    RenderTile(tile, sea[x, y]);

                    if (isClickable)
                    {
                        tile.MouseDown += Tile_MouseDown;
                        tile.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        _playerTiles[x, y] = tile; //hráčovu dlaždici si poznačím do mapy
                    }

                    Grid.SetRow(tile, y);
                    Grid.SetColumn(tile, x);

                    display.Children.Add(tile);
                }
            }
        }

        private void Tile_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!_playerCanShoot)
                return;

            //Když hráč klikne
            Rectangle tile = (Rectangle)sender;
            int x = Grid.GetColumn(tile);
            int y = Grid.GetRow(tile);
            Coordinates target = new Coordinates() { X = x, Y = y };

            //zjistím stav cíle
            bool hit = _computer.HandleShot(target);

            //vykreslím výsledek střely
            RenderTile(tile, _computer.GetPublicSea()[x, y]);
            RenderHitsDisplay(ComputerHitsDisplay, _computer.WrecksCount);

            //když počítači dojdou lodě
            if (!_computer.IsAlive)
            {
                //ohlásím vítězství a skončím
                MessageBox.Show("Victory", "You Win!");
                Close();
                return;
            }

            if (!hit)
            {
                _shotTimer.Start();
                _playerCanShoot = false;
            }
        }

        private void ComputerMove()
        {
            //počítač vymyslí cíl
            Coordinates target = _computer.ChooseTarget(_player.GetPublicSea());
            Rectangle tile = _playerTiles[target.X, target.Y];

            //zjistím stav cíle
            bool hit = _player.HandleShot(target);

            //vykreslím výsledek střely
            RenderTile(tile, _player.GetPublicSea()[target.X, target.Y]);
            RenderHitsDisplay(PlayerHitsDisplay, _player.WrecksCount);

            //když hráči dojdou lodě
            if (!_player.IsAlive)
            {
                //ohlásím prohru a skončím
                MessageBox.Show("Defeat", "You Lose!");
                Close();
                return;
            }

            if (hit)
            {
                _shotTimer.Start();
            }
            else 
            {
               _playerCanShoot = true;
            }
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
