using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merkij__7._3_teht_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä ensimmäinen merkkijono: ");
            string a = Console.ReadLine();

            Console.Write("Syötä toinen merkkijono: ");
            string b = Console.ReadLine();

            if (a == b)
            {
                Console.WriteLine("Merkkijonot ovat samoja.");
            }
            else
            {
                Console.WriteLine("Merkkijonot eivät ole samoja.");
            }
        }
    }
}


/*
Kirjoita ohjelma, joka tarkistaa, ovatko kaksi käyttäjän syöttämää merkkijonoa samoja.
*/