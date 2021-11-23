using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_07_Geometrie
{
    class Bod
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Bod(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }
        public bool JeShodnyS(Bod jinyBod)
        {
            return this.X == jinyBod.X && this.Y == jinyBod.Y;
        }
        public double VzdalenostOd(Bod jinyBod)
        {
            double dx = this.X - jinyBod.X;
            double dy = this.Y - jinyBod.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

    }
}
