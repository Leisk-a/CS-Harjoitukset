using System;

namespace parit__7._3_teht_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int luku);

            if (validInput)
            {
                if (luku % 2 == 0)
                    Console.WriteLine($"Luku on parillinen.");
                else
                    Console.WriteLine("Luku on pariton");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}


/*
Kirjoita ohjelma, joka tarkistaa, onko käyttäjän syöttämä luku parillinen vai pariton
 */