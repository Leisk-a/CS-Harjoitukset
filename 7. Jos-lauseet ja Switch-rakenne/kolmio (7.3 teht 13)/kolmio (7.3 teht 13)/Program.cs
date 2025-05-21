using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolmio__7._3_teht_13_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kolmion sivujen pituudet:");

            Console.Write("Ensimmäinen sivu: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Toinen sivu: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Kolmas sivu: ");
            double c = double.Parse(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("Kolmio on tasasivuinen.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Kolmio on tasakylkinen.");
            }
            else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                Console.WriteLine("Kolmio on suorakulmainen.");
            }
            else
            {
                Console.WriteLine("Kolmio on epäsäännöllinen.");
            }
        }
    }
}

/*
Kirjoita ohjelma, joka ottaa käyttäjältä kolmen sivun pituudet ja tarkistaa, onko kolmio tasakylkinen, tasasivuinen, suorakulmainen vai epäsäännöllinen.
*/