using System;

namespace _02_OOP_apod_Enum
{
    enum Obdobi : byte { Jaro, Leto, Podzim, Zima }
    class Program
    {
        static void Main(string[] args)
        {
            Obdobi chladne = Obdobi.Jaro;
            Console.WriteLine(chladne);

            Obdobi horke = chladne + 1;
            Console.WriteLine(horke);

            Obdobi divne = horke + 3;
            Console.WriteLine(divne);

            Obdobi test = (Obdobi)2;
            Console.WriteLine(test);

            //char pismeno = (char)('a' + 3);
            //Console.WriteLine(pismeno);

            Obdobi velke = (Obdobi)255;
            velke++;
            Console.WriteLine(velke);
        }
    }
}
