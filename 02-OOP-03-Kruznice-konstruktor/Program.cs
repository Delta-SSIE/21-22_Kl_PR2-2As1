using System;

namespace _02_OOP_03_Kruznice_konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kruznice k = new Kruznice(1);
                //k.SetPolomer(1);

                Console.WriteLine($"Kružnice o poloměru {k.GetPolomer()} cm má obvod {k.SpoctiObvod():0.00} cm a obsah {k.SpoctiObsah():0.00} cm^2.");
            }
            catch
            {
                Console.WriteLine("Došlo k nečekané chybě");
            }

            Kruznice l = new Kruznice();
           
        }

    }
}
