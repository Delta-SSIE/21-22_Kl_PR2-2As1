using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_04_Iface_Demo
{
    abstract class DopravniProstredek
    {
        public int PocetPasazeru { get; private set; }
        public int MaxRychlost { get; private set; }
        public string Popis { get; private set; }

        protected DopravniProstredek(int pocetPasazeru, int maxRychlost, string popis)
        {
            PocetPasazeru = pocetPasazeru;
            MaxRychlost = maxRychlost;
            Popis = popis;
        }
    }
}
