
/*
Kirjoita ohjelma, joka:

Lukee tiedoston ja laskee, kuinka monta kertaa tietty sana esiintyy tiedostossa.
Tulostaa esiintymien määrän käyttäjälle.
Vinkki: Käytä string.IndexOf ja silmukkaa laskemiseen.
*/

using System;
using System.IO;

namespace TietynLasku__13._2_teht_8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna tiedoston nimi: ");
            string tiedosto = Console.ReadLine();

            Console.Write("Anna sana jota etsit: ");
            string sana = Console.ReadLine();

            string teksti = File.ReadAllText(tiedosto);

            int laskuri = 0;
            int muuttuja = 0;

            while ((muuttuja = teksti.IndexOf(sana, muuttuja)) != -1)
            {
                laskuri++;
                muuttuja += sana.Length;
            }

            Console.WriteLine($"Sana {sana} esiintyy tiedostossa {laskuri} kertaa.");
        }
    }
}
