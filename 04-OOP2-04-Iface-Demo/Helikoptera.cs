using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_04_Iface_Demo
{
    class Helikoptera : DopravniProstredek, IMotorovy
    {
        public Helikoptera(int pocetPasazeru, int maxRychlost, int maxVykon) : base(pocetPasazeru, maxRychlost, "Vrtulník")
        {
            MaxVykon = maxVykon;
        }

        public TypMotoru Motor => TypMotoru.Benzin;

        public int MaxVykon { get; private set; }

        public void Napln()
        {
            Console.WriteLine("Vrtulník tankuje na základně");
        }
    }
}
