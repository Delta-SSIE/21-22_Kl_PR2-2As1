using System;

namespace _01_Uvod_01_Prohozeni_promennych
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            //dočasná proměnná

            //int tmp = x;
            //x = y;
            //y = tmp;


            //odčítání

            //x = x + y;
            //y = x - y;
            //x = x - y;


            //destructuring
            //(x, y) = (y, x);


            // XOR

            x = x ^ y;
            y = x ^ y;
            x = x ^ y;

            Console.WriteLine($"x: {x}, y: {y}");
        }
    }
}
