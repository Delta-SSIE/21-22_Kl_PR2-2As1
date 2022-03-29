using System;

namespace _04_OOP2_01_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Kun ferda = new Kun("Ferda");
            //Savec ferdaJinak = ferda; //nemusím přetypovat, je implicitní

            Savec blesk = new Kun("Blesk");
            //Kun bleskJinak = (Kun)blesk; //musím přetypovat, není automatické

            Velryba mobyDick = new Velryba("Moby Dick");
            //// mobyDick.Cvalej(); //nelze - není to kůň
            //Savec mobyJinak = mobyDick; //lze, velryba je také savec
            //Kun hybrid = (Kun)mobyJinak; //nelze, ale zjistí se až za běhu - runtime error
            //hybrid.Cvalej();

            ferda.OzviSe();
      
            //ferdaJinak.OzviSe();

            Savec[] zoo = new Savec[3];
            zoo[0] = ferda;
            zoo[1] = mobyDick;
            zoo[2] = blesk;

            foreach(Savec zvire in zoo)
            {
                zvire.OzviSe();
            }

            //Savec nikdo = new Savec(); //abstraktní třídu nejde instancovat

        }
    }
}
