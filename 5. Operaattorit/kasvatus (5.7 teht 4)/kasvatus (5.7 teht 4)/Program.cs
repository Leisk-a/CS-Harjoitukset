using System;
using System.Collections.Generic;

namespace kasvatus__5._7_teht_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna aloitusarvo:");
            string input = Console.ReadLine();
            bool validInput = double.TryParse(input, out double a);

            if (validInput)
            {
                a += 5;
                a *= 2;
                a /= 3;
                Console.WriteLine($"Luku on nyt {a}");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}

/*Kirjoita ohjelma, joka pyytää käyttäjältä aloitusarvon ja kasvattaa sitä seuraavilla tavoilla:

Lisää siihen luku 5 (+=),
Kertoo sen luvulla 2 (*=),
Jakaa sen luvulla 3 (/=).*/