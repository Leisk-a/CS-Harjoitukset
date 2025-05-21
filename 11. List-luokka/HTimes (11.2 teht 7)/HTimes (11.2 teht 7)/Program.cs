using System;
using System.Collections.Generic;

namespace HTimes__11._2_teht_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numerot = new List<int>() { 41, 52, 13, 63, 24, 52, 12, 1, 5, 6, 52, 65, 15, 89, 74, 23, 43 };

            Console.WriteLine("Anna kokonaisluku:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int etsittava);

            int count = 0;
            foreach (int numero in numerot)
            {
                if (numero == etsittava)
                {
                    count++;
                }
            }

            Console.WriteLine($"{etsittava} esiintyy {count} kertaa.");
        }
    }
}


/*
Laske, montako kertaa arvo esiintyy
Kirjoita ohjelma, joka:


Luo List<int>-listan, johon lisätään satunnaisia lukuja (esim. 10–20 lukua väliltä 1–5).
Pyytää käyttäjää syöttämään luvun.
Laskee ja tulostaa, montako kertaa käyttäjän antama luku esiintyy listassa.
*/