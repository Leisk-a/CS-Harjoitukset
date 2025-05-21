
/*
Kirjoita ohjelma, joka:

Lukee tiedoston ja etsii tietyn sanan (esim. "vanha").
Korvaa kaikki esiintymät toisella sanalla (esim. "uusi").
Tallentaa muutetun sisällön samaan tai uuteen tiedostoon.
Vinkki: Käytä string.Replace.
*/

using System;
using System.IO;

namespace haku__13._2_teht_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = "teksti.txt";
            string vanhaSana = "vanha";
            string uusiSana = "uusi";

            if (File.Exists(tiedosto))
            {
                string teksti = File.ReadAllText(tiedosto);
                string uusiTeksti = teksti.Replace(vanhaSana, uusiSana);

                File.WriteAllText(tiedosto, uusiTeksti);

                Console.WriteLine("Uusi teksti (vanha > uusi).\n");
                string[] lines = File.ReadAllLines(tiedosto);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
