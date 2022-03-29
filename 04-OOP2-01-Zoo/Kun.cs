using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_01_Zoo
{
    class Kun : Savec
    {
        public Kun(string jmeno) : base(jmeno)
        {
            Console.WriteLine("Vytvářím nového koně");
        }
        public void Cvalej()
        {
            Console.WriteLine("Dupity dup");
        }
        public override void OzviSe()
        {
            Console.WriteLine($"{Jmeno} dělá Íhaháááá");
        }
    }
}
