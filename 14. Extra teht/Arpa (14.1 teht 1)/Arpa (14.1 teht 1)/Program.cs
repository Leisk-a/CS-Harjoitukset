
/*
Kirjoita ohjelma, joka arpoo kahden arpakuution silmäluvut. Jos molemmat ovat samoja, tulostetaan 
"samat" ja jos molemmat ovat ykkösiä tulostetaan lisäksi "snake eyes" muussa tapauksessa tulostetaan "erit".
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arpa__14._1_teht_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int a = random.Next(1, 10);
            int b = random.Next(1, 10);

            Console.WriteLine($"Arvotut luvut ovat {a} ja {b}");

            if (a == b)
            {
                Console.WriteLine("Luvut ovat samat.");

                if (a == b && a <= 1)
                {
                    Console.WriteLine("Snake eyes.");
                }
            }
            else
            {
                Console.WriteLine("Luvut ovat erit.");
            }
        }
    }
}
