using System;

namespace Whilelaskin__8._2_teht_3_
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Anna kokonaisluku:");
                string input = Console.ReadLine();
                bool validInput = int.TryParse(input, out int i);
                if (i < 0 || !validInput)
                    break;
                sum += i; 
            }
            Console.WriteLine($"{sum}");
        }
    }
}


// Kirjoita ohjelma, joka laskee ja tulostaa lukujen summan, kunnes käyttäjä syöttää negatiivisen luvun.