using System;

namespace _02_OOP_05_Kruznice_Vlastnosti
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kruznice k = new Kruznice(1);
                //k.SetPolomer(1);

                Console.WriteLine($"Kružnice o poloměru {k.Polomer} cm má obvod {k.Obvod:0.00} cm a obsah {k.Obsah:0.00} cm^2.");

                //k.Polomer = -2;
                k.Polomer += 1;
                

                Console.WriteLine($"Kružnice o poloměru {k.Polomer} cm má obvod {k.Obvod:0.00} cm a obsah {k.Obsah:0.00} cm^2.");

                Console.WriteLine(k);

            }
            catch
            {
                Console.WriteLine("Došlo k nečekané chybě");
            }

            Kruznice l = new Kruznice();


        }
    }
}
