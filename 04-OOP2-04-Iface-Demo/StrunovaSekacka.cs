using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_04_Iface_Demo
{
    class StrunovaSekacka : IMotorovy
    {
        public TypMotoru Motor => TypMotoru.Benzin;

        public int MaxVykon { get; private set; }

        public StrunovaSekacka(int maxVykon)
        {
            MaxVykon = maxVykon;
        }

        //public void Napln()
        //{
        //    Console.WriteLine("Dolévám benzín");
        //}
        public void Dolej()
        {
            Console.WriteLine("Dolévám benzín");
        }

        void IMotorovy.Napln()
        {
            Dolej();
        }
    }
}
