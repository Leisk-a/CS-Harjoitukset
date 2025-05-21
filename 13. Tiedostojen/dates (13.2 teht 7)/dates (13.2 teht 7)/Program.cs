
/*
Kirjoita ohjelma, joka:

Lisää käyttäjän syöttämän tekstin tiedoston loppuun (päiväkirjan tapaan).
Jokainen lisäys aloitetaan päivämäärällä ja kellonajalla (esim. "2025-01-02 14:30: Tämä on uusi merkintä.").
Vinkki: Käytä DateTime.Now ja StreamWriter lisäämään tiedostoon.
*/

using System;
using System.IO;

namespace dates__13._2_teht_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = "teksti.txt";

            Console.WriteLine("Lisää teksti (tyhjä rivi lopettaa):");
            string lisaa = Console.ReadLine();

            while (lisaa != "")
            {
                string aika = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                using (StreamWriter kirjoittaja = new StreamWriter(tiedosto, true))
                {
                    kirjoittaja.WriteLine($"{aika}: {lisaa}");
                }

                Console.WriteLine("Lisää teksti (tyhjä rivi lopettaa):");
                lisaa = Console.ReadLine();
            }

            Console.WriteLine("Merkinnät tallennettu tiedostoon " + tiedosto);
        }
    }
}
