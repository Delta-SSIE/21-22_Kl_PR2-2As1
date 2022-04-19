using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_03_Ucty
{
    class Ucet
    {
        public double Stav { get; protected set; }
        public virtual void Uloz (double castka)
        {
            if (castka <= 0)
                throw new ArgumentOutOfRangeException();

            Stav += castka;
        }
        public virtual void Vyber (double castka)
        {
            if (castka > Stav)
                throw new ArgumentOutOfRangeException();

            Stav -= castka;
        }
        public override string ToString()
        {
            return $"Účet, stav {Stav} Kč";
        }
    }
}
