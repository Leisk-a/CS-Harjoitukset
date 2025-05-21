using System;

namespace ikä__7._3_teht_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ikäsi:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int ika);

            if (validInput && ika <= 17)
            {
                Console.WriteLine("Alaikäinen.");
            }
            if (validInput && ika >= 18) 
            {
                Console.WriteLine("Aikuinen.");
            }
        }
    }
}


/*
Kirjoita ohjelma, joka tarkistaa käyttäjän iän ja kertoo, mihin ikäryhmään hän kuuluu.
 */