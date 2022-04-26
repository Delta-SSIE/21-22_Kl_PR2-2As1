using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_04_Iface_Demo
{
    interface IMotorovy
    {
        TypMotoru Motor { get; }
        int MaxVykon { get; }
        void Napln();
    }
}
