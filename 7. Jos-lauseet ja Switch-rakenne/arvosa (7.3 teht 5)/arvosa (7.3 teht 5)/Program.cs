using System;

namespace arvosa__7._3_teht_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna pistemäärä (0-100): ");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int b);

            double i = b;

            if (i < 0 || i > 100)
            {
                Console.WriteLine("Virheellinen pistemäärä.");
                return;
            }
            else if (i >= 85)
            {
                i = 5;
            }
            else if (i >= 68)
            {
                i = 4;
            }
            else if (i >= 51)
            {
                i = 3;
            }
            else if (i >= 34)
            {
                i = 2;
            }
            else if (i >= 17)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }

            Console.WriteLine($"Pistemäärä: {b} Arvosana: {i}");
        }
    }
}


/*
Kirjoita ohjelma, joka tarkistaa käyttäjän antaman 
pistemäärän ja määrittää arvosanan asteikolla 0–100.
 */