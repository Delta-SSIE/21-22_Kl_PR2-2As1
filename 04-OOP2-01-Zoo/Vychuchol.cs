using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_01_Zoo
{
    class Vychuchol : Savec
    {
        public Vychuchol(string jmeno) : base(jmeno)
        {
        }

        public override void OzviSe()
        {
            Console.WriteLine("Pýsk");
        }
    }
}
