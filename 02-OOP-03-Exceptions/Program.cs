using System;

namespace _02_OOP_03_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej celé číslo");
            try 
            { 
                int cislo = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Zadal jsi nesmysl, troubo!");
            }
        }
    }
}
