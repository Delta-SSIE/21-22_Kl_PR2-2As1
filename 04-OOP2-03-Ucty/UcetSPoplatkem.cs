using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_03_Ucty
{
    class UcetSPoplatkem : Ucet
    {
        public double PoplatekZaVyber { get; set; }
        public double PoplatekZaVklad { get; set; }

        public override void Uloz(double castka)
        {
            if (castka < PoplatekZaVklad)
                throw new ArgumentOutOfRangeException();

            this.Stav += castka - PoplatekZaVklad;
            //castka -= PoplatekZaVklad;
            //base.Uloz(castka);
        }

        public override void Vyber(double castka)
        {
            if (Stav < castka + PoplatekZaVyber)
                throw new ArgumentOutOfRangeException();

            Stav -= castka + PoplatekZaVyber;
        }
    }
}
