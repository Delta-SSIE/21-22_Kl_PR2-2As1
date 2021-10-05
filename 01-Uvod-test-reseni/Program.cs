using System;
using System.Linq;

namespace _01_Uvod_test_reseni
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] slova = { "slovo", "dvě slova", "45dsa456ds56a45dsa" };

        }

        static bool JsouDelsiNez(string[] retezce, int limit)
        {
            for (int i = 0; i < retezce.Length; i++)
            {
                if (retezce[i].Length <= limit)
                    return false;
            }

            return true;

            foreach (string retezec in retezce)
            {
                if (retezec.Length <= limit)
                    return false;
            }
            return true;

        } 
    }
}
