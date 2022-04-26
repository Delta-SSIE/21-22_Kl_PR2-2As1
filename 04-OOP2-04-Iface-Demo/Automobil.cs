using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_04_Iface_Demo
{
    class Automobil : DopravniProstredek, IPojizdny, IMotorovy
    {
        public Automobil(int pocetPasazeru, int maxRychlost, TypMotoru motor, int maxVykon) : base(pocetPasazeru, maxRychlost, "automobil")
        {
            Motor = motor;
            MaxVykon = maxVykon;
        }
        public int PocetKol => 4;
        public TypMotoru Motor { get; private set; }
        public int MaxVykon { get; private set; }
        public void Napln()
        {
            Console.WriteLine("Zastavuju na benzince");
        }
    }
}
