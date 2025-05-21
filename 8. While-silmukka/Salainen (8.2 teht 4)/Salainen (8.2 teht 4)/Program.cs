using System;

namespace Salainen__8._2_teht_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 100);

            while (true)
            {
                Console.WriteLine("Anna random kokonaisluku (1 - 100):");
                string input = Console.ReadLine();
                bool validInput = int.TryParse(input, out int i);

                if (secretNumber > i)
                    Console.WriteLine("Liian pieni.");
               
                if (secretNumber < i)
                    Console.WriteLine("Liian suuri.");

                if (secretNumber == i)
                    break; 
            }
            Console.WriteLine($"Arvasit luvun oikein, luku oli {secretNumber}.");
        }
    }
}


/*
Kirjoita ohjelma, joka pyytää käyttäjää arvaamaan salaisen luvun (1–100). Ohjelma antaa vihjeitä ("liian suuri" tai "liian pieni"), kunnes arvaus on oikein.

     Random rand = new Random();
     int secretNumber = rand.Next(1, 101);
 */