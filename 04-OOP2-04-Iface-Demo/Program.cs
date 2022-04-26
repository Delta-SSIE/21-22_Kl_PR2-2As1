using System;
using System.Linq;

namespace _04_OOP2_04_Iface_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Kocarek k = new Kocarek(4, "Finnie");
           
            IPojizdny kJinak = k;

            StrunovaSekacka sekacka = new StrunovaSekacka(5);
            //sekacka.Dolej();
            
            IMotorovy sekackaJinak = sekacka;
            //sekackaJinak.Napln();

            Bicykl plecka = new Bicykl(35);

            Helikoptera vrtulnik = new Helikoptera(2, 350, 200);

            Automobil brouk = new Automobil(4, 80, TypMotoru.Benzin, 45);
            Automobil mondeo = new Automobil(5, 250, TypMotoru.Diesel, 135);

            IPojizdny[] jezditka = new IPojizdny[] { k, plecka, brouk, mondeo };
            Console.WriteLine($"Celkem je tu {SpocitejKola(jezditka)} kol.");

            IMotorovy[] motory = new IMotorovy[] { sekacka, vrtulnik, brouk, mondeo };
            foreach (IMotorovy motorovost in motory)
            {
                motorovost.Napln();
            }
        }
        static int SpocitejKola(IPojizdny[] veci)
        {
            //return veci.Select(x => x.PocetKol).Sum();
            int pocet = 0;
            foreach (IPojizdny vec in veci)
            {
                pocet += vec.PocetKol;
            }
            return pocet;
        }
    }
}
