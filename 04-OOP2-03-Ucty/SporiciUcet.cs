using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_03_Ucty
{
    class SporiciUcet : Ucet
    {

        private double _urokovaMira;

        public double UrokovaMira
        {
            get { return _urokovaMira; }
            set 
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                _urokovaMira = value; 
            }
        }
        public void Urokuj()
        {
            Stav *= 1 + _urokovaMira / 100; 
        }

    }
}
