using System;

namespace _01_Uvod_00_Opakovani_syntaxe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //int cislo = 100;

            //string stav;
            //if (cislo > 25)
            //    stav = "velké";
            //else
            //    stav = "malé";

            //string stav = cislo > 25 ? "velké" : "malé";

            //string stav = cislo < 5 ? "prťavé"
            //            : cislo < 7 ? "malé"
            //            : cislo < 9 ? "tak akorát"
            //            : "velké";



            //Console.WriteLine($"Číslo je {stav}");

            //for (int poradi = 0; poradi < 20; poradi++)
            //{
            //    Console.WriteLine(poradi);
            //}

            //int cislo = 100;
            //while (cislo < 20)
            //{
            //    Console.WriteLine(cislo);
            //    cislo++;
            //}

            //do
            //{
            //    Console.WriteLine(cislo);
            //    cislo++;
            //}
            //while (cislo < 20);


            //int cislo = 1;
            //while (cislo < 30)
            //{
            //    cislo++;
            //    if (cislo % 8 == 0)
            //        continue;
            //        //break;
            //    Console.WriteLine(cislo);
            //}

            int x = 10;
            int y = 20;

            double quotient = (double)x / y;
            Console.WriteLine($"Podíl {x} a {y} je {quotient}.");
        }
    }
}
