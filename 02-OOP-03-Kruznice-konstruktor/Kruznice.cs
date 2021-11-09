using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_03_Kruznice_konstruktor
{
    
    class Kruznice
    {
        private double _polomer;
        public double GetPolomer()
        {
            return _polomer;
        }
        public void SetPolomer(double hodnota)
        {
            if (hodnota < 0)
            {
                //Console.WriteLine("Neplatná hodnota");
                throw new ArgumentOutOfRangeException("Negative diameter");
            }
            else // když je to OK
            {
                _polomer = hodnota;
            }
        }

        public Kruznice()
        {
            SetPolomer(0);
        }

        public Kruznice (double polomer)
        {
            SetPolomer(polomer);
        }

        public double SpoctiObvod()
        {
            return 2 * Math.PI * _polomer;
        }

        public double SpoctiObsah()
        {
            return Math.PI * _polomer * _polomer;
        }
    }
}
