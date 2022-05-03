using System;

namespace _04_OOP2_IFace_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto[] auta = new Auto[]
            {
                new Auto("Form Mondeo", 230),
                new Auto("Hyperloop", 420),
                new Auto("Škoda Felicia", 150),
                new Auto("Trabant", 80),
                new Auto("VW Brouk", 90),
                new Auto("Porsche Carrera", 330),
            };

            foreach (Auto auto in auta)
            {
                Console.WriteLine($"{auto.Typ}: {auto.MaxRychlost}");
            }

            Array.Sort(auta);
            Console.WriteLine();

            foreach (Auto auto in auta)
            {
                Console.WriteLine($"{auto.Typ}: {auto.MaxRychlost}");
                
            }

        }
    }

    class Auto : IComparable
    {
        public string Typ { get; set; }
        public int MaxRychlost { get; set; }
        public Auto(string typ, int maxRychlost)
        {
            Typ = typ;
            MaxRychlost = maxRychlost;
        }

        //public int CompareTo(object obj)
        //{
        //    Auto druheAuto = obj as Auto;
        //    return MaxRychlost.CompareTo(druheAuto.MaxRychlost);
        //}

        public int CompareTo(object obj)
        {
            Auto druheAuto = obj as Auto;

            if (druheAuto == null) //null nechám při třídění na konec
                return 1;

            //return this.MaxRychlost - druheAuto.MaxRychlost;
            if (this.MaxRychlost < druheAuto.MaxRychlost)
                return +1;
            else if (this.MaxRychlost == druheAuto.MaxRychlost)
                return 0;
            else
                return -1;
        }
    }
}
