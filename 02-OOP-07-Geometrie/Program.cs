using System;

namespace _02_OOP_07_Geometrie
{
    class Program
    {
        static void Main(string[] args)
        {
            Bod A = new Bod(3, -1);
            //Console.WriteLine(A);

            Bod B = new Bod(5, 2);
            Bod C = new Bod(3, -1);

            if (A.JeShodnyS(B))
            {
                Console.WriteLine("Body A a B se shodují");
            }
            else
            {
                Console.WriteLine("Body A a B se liší");
            }

            if (A.JeShodnyS(C))
            {
                Console.WriteLine($"Body {A} a {C} se shodují");
            }
            else
            {
                Console.WriteLine($"Body {A} a {C} se liší");
            }

            Console.WriteLine(A.VzdalenostOd(B));
            Console.WriteLine(A.VzdalenostOd(C));

        }
    }
}
