using System;
using System.Collections.Generic;
using System.Linq;

namespace tmp
{
    enum SexType : byte { Male, Female }
    class MainClass
    {

        public static void Main(string[] args)
        {

            //vytvoříme jeden zkušební objekt
            Person tom = new Person
            {
                Name = "Tom",
                Surname = "Riddle",
                Age = 9,
                Sex = SexType.Male
            };

            //ověříme, že jsme správně zapsali jeho představení
            Console.WriteLine(tom.IntroduceSelf());

            // nyní připravíme pole osob
            Person[] friends = new Person[]
            {
                new Person {
                    Name = "Thomas",
                    Surname = "Carter",
                    Age = 17,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Lillian",
                    Surname = "Carter",
                    Age = 19,
                    Sex = SexType.Female
                },
                new Person {
                    Name = "Jim",
                    Surname = "Pearson",
                    Age = 54,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Lou",
                    Surname = "Lacey",
                    Age = 36,
                    Sex = SexType.Female
                },
                new Person {
                    Name = "Minnie",
                    Surname = "Stanfords",
                    Age = 84,
                    Sex = SexType.Female
                },
                new Person {
                    Name = "Quincy",
                    Surname = "Dean",
                    Age = 12,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Steve",
                    Surname = "Blake",
                    Age = 61,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Andrew",
                    Surname = "Holmes",
                    Age = 33,
                    Sex = SexType.Male
                }
            };

        }
        public static void FindKids(Person[] list)
        {
            foreach (var p in list.Where(x => x.Age < 38))
            {
                Console.WriteLine(p.IntroduceSelf());
            }
            // projde celý seznam - pole list a na dětech (ty jsou pod 18 let) zavolá metodu IntroduceSelf()
            // dospělých si nevšímá
        }

        public static void FindWomen(Person[] list)
        {
            // projde celý seznam - pole list a na ženách zavolá metodu IntroduceSelf()
            // chlapů si nevšímá
        }

    }
    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public SexType Sex;

        public string IntroduceSelf()
        {
            //zde je zatím výjimka, která říká "ještě není hotovo" - nahraďte ji správným kódem
            //throw new NotImplementedException();
            return $"{Name} {Surname}";
        }
    }
}
