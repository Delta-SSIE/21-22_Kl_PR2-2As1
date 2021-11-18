using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_05_Kruznice_Vlastnosti
{
    class Kruznice
    {
        private double _polomer;

        public double Polomer
        {
            get
            {
                return _polomer;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Negative diameter");
                }
                else // když je to OK
                {
                    _polomer = value;
                }
            }

        }

        public Kruznice()
        {
            Polomer = 0;
        }

        public Kruznice(double polomer)
        {
            Polomer = polomer;
        }

        //public double SpoctiObvod()
        //{
        //    return 2 * Math.PI * _polomer;
        //}

        public double Obvod
        {
            get
            {
                return 2 * Math.PI * _polomer;
            }
        }

        public double Obsah
        {
            get
            {
                return Math.PI * _polomer * _polomer;
            }
        }

        public override string ToString()
        {
            return $"Kružnice o poloměru {_polomer}";
        }
    }
}
