using System;

namespace Greet__12._2_teht_2_
{
    class Program
    {
        static void Greet(string nimi)
        {
            Console.WriteLine($"Hei {nimi}!");
        }

        static void Main()
        {
            Console.WriteLine("Anna nimesi:");
            string nimi = Console.ReadLine();
            Greet(nimi);
        }
    }
}


/*
Kirjoita metodi Greet, joka ottaa vastaan käyttäjän nimen ja tulostaa tervehdyksen.
 */