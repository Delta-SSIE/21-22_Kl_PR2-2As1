using System;

namespace _01_Uvod_02_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Zadej číslo: ");

            //string nacteno = Console.ReadLine();

            //int cislo = Convert.ToInt32(nacteno);
            //int cislo = int.Parse(nacteno);
            //
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());

            //int cislo;

            //if (int.TryParse(nacteno, out cislo))
            //{
            //    Console.WriteLine($"Zadal jsi {cislo}.");
            //}
            //else
            //{
            //    Console.WriteLine("To není platné číslo!");
            //}


            Console.Write("Zadej kladné číslo: ");
            string nacteno = Console.ReadLine();

            double cislo;

            while( !double.TryParse(nacteno, out cislo))
            {
                Console.Write("To není platné číslo, ňoumo! Zadej znovu: ");
                nacteno = Console.ReadLine();
            }

            Console.WriteLine($"Zadal jsi {cislo}.");

        }
    }
}
