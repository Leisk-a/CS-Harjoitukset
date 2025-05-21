using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nimi__11._2_teht_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nimet = new List<string>() { "Ismo", "Lauri", "Okko", "Sofia" };

            Console.Write("Anna nimi: ");
            string nimi = Console.ReadLine();

            if (nimet.Contains(nimi))
            {
                Console.WriteLine($"{nimi} löytyi listalta.");
            }
            else
            {
                Console.WriteLine($"{nimi} ei löytynyt listalta.");
            }
        }
    }
}


/*
Etsi nimi listasta
Kirjoita ohjelma, joka:


Luo List<string>-listan, jossa on muutama nimi, esim. "Anna", "Matti", "Liisa", "Pekka".
Pyytää käyttäjältä nimeä.
Tarkistaa, onko nimi listassa, ja tulostaa vastaavan viestin.
 */