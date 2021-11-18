using System;

namespace _02_OOP_06_Ucet
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucet prasatko = new Ucet();
            Console.WriteLine(prasatko);

            prasatko.Uloz(100);
            Console.WriteLine(prasatko);

            prasatko.Uloz(150);
            Console.WriteLine(prasatko);

            int vyber = 80;

            if (prasatko.Vyber(vyber))
                Console.WriteLine($"Vybral jsem {vyber} Kč.");
            else
                Console.WriteLine($"Nepovedlo se vybrat {vyber} Kč.");

            Console.WriteLine(prasatko);


            vyber = 800;

            if (prasatko.Vyber(vyber))
                Console.WriteLine($"Vybral jsem {vyber} Kč.");
            else
                Console.WriteLine($"Nepovedlo se vybrat {vyber} Kč.");

            Console.WriteLine(prasatko);

            prasatko.Urokuj(3.3);
            Console.WriteLine(prasatko);

            Console.WriteLine();
            Console.WriteLine(prasatko.GetTransactionLog());

            //prasatko.Uloz(100);
            //int obdobi = 0;
            //double urokovaMira = 7;

            //while (prasatko.Zustatek < 200)
            //{
            //    prasatko.Urokuj(urokovaMira);
            //    obdobi++;
            //}

            //Console.WriteLine($"Na zdvojnásobení vkladu při míře {urokovaMira} p.a. je třeba čekat {obdobi} let.");

            //prasatko.Uloz(-5);
        }
    }
}
