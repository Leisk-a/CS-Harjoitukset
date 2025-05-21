/*
Kirjoita ohjelma, joka:

Lukee tiedoston rivit.
Lisää jokaisen rivin alkuun rivin numeron (esim. "1: Tämä on ensimmäinen rivi").
Kirjoittaa muutetut rivit uuteen tiedostoon.
Vinkki: Käytä StreamReader ja StreamWriter.
*/

using System;
using System.IO;

namespace add__13._2_teht_3_
{
    internal class Program
    {
        static void Main()
        {
            string file1 = "a.txt";
            string file2 = "new.txt";
            int rivi = 1;

            if (File.Exists(file1))
            {
                string[] lines = File.ReadAllLines(file1);

                using (StreamWriter writer = new StreamWriter(file2))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine($"{rivi}: {line}");
                        rivi++;
                    }
                }

                Console.WriteLine($"Rivit numeroidaan ja tallennetaan tiedostoon {file2}\n");
            }
            else
            {
                Console.WriteLine($"Tiedostoa {file1} ei löytynyt.");
            }

            if (File.Exists(file2))
            {
                Console.WriteLine("Uusi tiedosto:");
                string content = File.ReadAllText(file2);
                Console.WriteLine(content);
            }
        }
    }
}