using System;
using System.Collections.Generic;

namespace Fix__11._2_teht_8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nimet = new List<string>() { "Timo", "Aarni", "Kari", "Marjaatta", "Jussi", "Pekka" };

            Console.Write("Nimi lista: ");
            foreach (string nimi in nimet)
            {
                Console.Write(nimi + " ");
            }

            Console.WriteLine("\n\nAnna nimi jonka haluat muuttaa listalta:");
            string vanhanimi = Console.ReadLine();

            Console.WriteLine("\nAnna uusi nimi:");
            string uusinimi = Console.ReadLine();

            int i = nimet.IndexOf(vanhanimi);

            if (i != -1)
            {
                nimet[i] = uusinimi;
            }
            else
            {
                Console.WriteLine("Nimeä ei listalla.");
            }

            Console.WriteLine("\nUusi lista:");
            foreach (string nimi in nimet)
            {
                Console.Write(nimi + " ");
            }
        }
    }
}


/*
Päivitä tietty arvo
Kirjoita ohjelma, joka:


Luo List<string>-listan, jossa on muutama nimi.
Pyytää käyttäjältä nimeä ja uutta nimeä.
Korvaa listassa käyttäjän antaman nimen uudella nimellä, jos se löytyy listasta.
Tulostaa päivitetyn listan.
 */