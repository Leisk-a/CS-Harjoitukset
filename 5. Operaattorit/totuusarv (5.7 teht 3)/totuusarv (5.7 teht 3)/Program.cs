using System;

namespace totuusarv__5._7_teht_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen totuus arvo (true/false):");
            string input = Console.ReadLine();
            bool validInput1 = bool.TryParse(input, out bool a );
            Console.WriteLine("Anna toinen totuus arvo (true/false):");
            string input2 = Console.ReadLine();
            bool validInput2 = bool.TryParse(input2, out bool b);

            if (validInput1 && validInput2)
            {
                Console.WriteLine("And on " +(a && b));
                Console.WriteLine("Or on " +(a || b));
                Console.WriteLine("Not on "+(!a));
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen totuus arvo (tue/false).");
            }

        }
    }
}

/*Kirjoita ohjelma, joka pyytää käyttäjältä kahta totuusarvoa (true/false). 
Tulosta seuraavat loogisten operaattoreiden tulokset:

AND(&&),
OR(||),
NOT(!).
Esim: 

Syötä ensimmäinen totuusarvo (true/false): true
Syötä toinen totuusarvo (true/false): false
AND: false
OR: true
NOT(ensimmäinen): false*/