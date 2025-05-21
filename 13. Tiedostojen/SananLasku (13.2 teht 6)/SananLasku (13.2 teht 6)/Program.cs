
/*
Kirjoita ohjelma, joka:

Lukee tiedoston ja laskee, kuinka monta sanaa tiedostossa on.
Tulostaa sanojen määrän käyttäjälle.
Vinkki: Jaa rivi sanoihin käyttämällä string.Split.
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SananLasku__13._2_teht_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tiadosto = "teksti.txt";
            int sanat = 0;


            if (File.Exists(tiadosto))
            {
                using (StreamReader reader = new StreamReader(tiadosto))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] sananlasku = line.Split(' ');

                        sanat += sananlasku.Length;
                    }
                }
            }
            Console.WriteLine($"Tiadostossa on {sanat} sanaa.");
        }
    }
}
