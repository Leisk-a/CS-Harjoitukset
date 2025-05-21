using System;

namespace _0001__5._7_teht_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen kokonaisluku:");
            string input = Console.ReadLine();
            bool validInput1 = int.TryParse(input, out int e);
            Console.WriteLine("Anna toinen kokonaisluku:");
            string input2 = Console.ReadLine();
            bool validInput2 = int.TryParse(input2, out int t);

            if (validInput1 && validInput2)
            {
                Console.WriteLine($"AND {e & t}");
                Console.WriteLine($"OR {e | t}");
                Console.WriteLine($"XOR {e ^ t}")
                Console.WriteLine($"Vasen siirto {e << 1}");
                Console.WriteLine($"Oikea siirto {e >> 1}");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen kokonaisluku.");
            }
        }
    }
}


/*Kirjoita ohjelma, joka pyytää käyttäjältä kahta kokonaislukua ja näyttää niiden:

AND (&),
OR (|),
XOR (^),
vasemman siirron (<<),
oikean siirron (>>).
Esim:

Syötä ensimmäinen luku: 6
Syötä toinen luku: 3
AND: 2
OR: 7
XOR: 5
Vasemman siirto (6 << 1): 12
Oikean siirto (6 >> 1): 3*/