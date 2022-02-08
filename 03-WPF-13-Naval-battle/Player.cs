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
            _shipCount = shipCount;
            _seaSize = seaSize;

            CreateSea();
            PlaceShips();
        }

        private void CreateSea()
        {
            throw new NotImplementedException();
        }
        private void PlaceShips()
        {
            throw new NotImplementedException();
        }
        public Coordinates ChooseTarget(TileState[,] opponentSea)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Receives target coordinates, marks down result to private sea
        /// </summary>
        /// <param name="target">Target to be shot at</param>
        /// <returns>true on hitting a ship, false otherwise</returns>
        public bool HandleShot(Coordinates target)
        {
            throw new NotImplementedException();
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
