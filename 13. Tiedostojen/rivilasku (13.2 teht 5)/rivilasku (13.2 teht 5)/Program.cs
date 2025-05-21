
/*
Kirjoita ohjelma, joka:

Lukee tiedoston ja laskee, kuinka monta riviä tiedostossa on.
Tulostaa rivien määrän käyttäjälle.
Vinkki: Käytä StreamReader ja silmukkaa laskemiseen.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rivilasku__13._2_teht_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tiadosto = "teksti.txt";
            int rivit = 0;


            if (File.Exists(tiadosto))
            {
                using (StreamReader reader = new StreamReader(tiadosto))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        rivit ++;
                    }
                }
            }
            Console.WriteLine($"Tiadostossa on {rivit} riviä.");
        }
    }
}
