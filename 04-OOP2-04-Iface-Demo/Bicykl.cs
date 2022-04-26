using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_04_Iface_Demo
{
    class Bicykl : DopravniProstredek, IPojizdny
    {
        public int PocetKol => 2;
        //public int PocetKol
        //{
        //    get
        //    {
        //        return 2;
        //    }
        //}
        public Bicykl(int maxRychlost) : base(1, maxRychlost, "Jízdní kolo")
        {
        }
    }
}
