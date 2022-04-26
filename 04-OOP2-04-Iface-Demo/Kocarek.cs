using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_04_Iface_Demo
{
    class Kocarek : IPojizdny
    {
        public int PocetKol { get; private set; }
        public string JmenoPanny;

        public Kocarek(int pocetKol, string jmeno)
        {
            PocetKol = pocetKol;
            JmenoPanny = jmeno;
        }
    }
}
