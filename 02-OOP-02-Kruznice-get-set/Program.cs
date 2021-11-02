using System;

namespace _02_OOP_02_Kruznice_get_set
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
                Kruznice k = new Kruznice();
                k.SetPolomer(1);

                Console.WriteLine($"Kružnice o poloměru {k.GetPolomer()} cm má obvod {k.SpoctiObvod():0.00} cm a obsah {k.SpoctiObsah():0.00} cm^2.");
            }
            catch
            {
                Console.WriteLine("Došlo k nečekané chybě");
            }
        }
    }
}
