using System;

namespace parit__7._3_teht_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku tarkistaaksesi onko se parillinen:");
            string input1 = Console.ReadLine();
            bool validInput1 = int.TryParse(input1, out int a);

            if (validInput1)
            {
                if (a % 2 == 0)
                    Console.WriteLine($"Luku on parillinen.");
                else
                    Console.WriteLine("Luku on pariton");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen kokonaisluku.");
            }
        }
    }
}


// Kirjoita ohjelma, joka tarkistaa, onko käyttäjän syöttämä luku parillinen vai pariton