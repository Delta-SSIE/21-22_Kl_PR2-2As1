using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WPF_13_Naval_battle
{
    class Player
    {
        private int _shipCount;
        private int _seaSize;

        private TileState[,] _sea;

        public int WrecksCount { get; private set; }
        public bool IsAlive
        {
            get
            {
                return WrecksCount < _shipCount;
            }
        }

        public Player(int shipCount, int seaSize)
        {
            if (shipCount < 1)
                throw new ArgumentException("Too few ships");

            if (seaSize < 2)
                throw new ArgumentException("Sea is too little");

            if (shipCount >= seaSize * seaSize)
                throw new ArgumentException("Too many ships, increase sea size");
            
            _shipCount = shipCount;
            _seaSize = seaSize;

            CreateSea();
            PlaceShips();
        }

        private void CreateSea()
        {
            _sea = new TileState[_seaSize, _seaSize];
        }
        private void PlaceShips()
        {
            int placedShips = 0;
            Random rnd = new Random();

            while (placedShips < _shipCount)
            {
                int x = rnd.Next(_seaSize);
                int y = rnd.Next(_seaSize);
                if (_sea[x, y] != TileState.Ship)
                {
                    _sea[x, y] = TileState.Ship;
                    placedShips++;
                }
            }
        }
        public Coordinates ChooseTarget(TileState[,] opponentSea)
        {
            Random rnd = new Random();
            Coordinates target = null;

            do
            {
                int x = rnd.Next(_seaSize);
                int y = rnd.Next(_seaSize);
                if (opponentSea[x, y] == TileState.Empty)
                {
                    target = new Coordinates() { X = x, Y = y };
                }
            }
            while (target == null);

            return target;
        }
        /// <summary>
        /// Receives target coordinates, marks down result to private sea
        /// </summary>
        /// <param name="target">Target to be shot at</param>
        /// <returns>true on hitting a ship, false otherwise</returns>
        public bool HandleShot(Coordinates target)
        {
            TileState state = _sea[target.X, target.Y];

            switch (state)
            {
                case TileState.Empty:
                    _sea[target.X, target.Y] = TileState.Missed;
                    return false;
                case TileState.Ship:
                    _sea[target.X, target.Y] = TileState.Wreck;
                    WrecksCount++;
                    return true;
                case TileState.Wreck:
                    return false;
                case TileState.Missed:
                    return false;
                default:
                    return false; // impossible case
            }
        }
        public TileState[,] GetPrivateSea()
        {
            return (TileState[,])_sea.Clone();
        }
        public TileState[,] GetPublicSea()
        {
            TileState[,] publicSea = new TileState[_seaSize, _seaSize];
            for (int x = 0; x < _seaSize; x++)
            {
                for (int y = 0; y < _seaSize; y++)
                {
                    //TileState state = _sea[x, y];
                    //if (state == TileState.Ship)
                    //    publicSea[x, y] = TileState.Empty;
                    //else
                    //    publicSea[x, y] = _sea[x, y];

                    publicSea[x, y] = (_sea[x, y] == TileState.Ship) ? TileState.Empty : _sea[x, y];
                }
            }
            return publicSea;
        }
    }
}
