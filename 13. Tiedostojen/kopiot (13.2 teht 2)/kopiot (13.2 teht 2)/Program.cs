using System;
using System.IO;

namespace kopiot__13._2_teht_2_
{
    class Program
    {
        static void Main()
        {
            string sourcePath = "a.txt";
            string destinationPath = "kopio.txt";

            if (File.Exists(sourcePath))
            {
                string content = File.ReadAllText(sourcePath);
                Console.WriteLine($"Tiedoston {sourcePath} sisältö:\n");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"Tiedostoa {sourcePath} ei löytynyt.\n");
            }

            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, destinationPath, true);
                Console.WriteLine($"Tiedosto kopioitu: {destinationPath}");
            }
            else
            {
                Console.WriteLine($"Lähdetiedostoa {sourcePath} ei löytynyt.\n");
            }

            if (File.Exists(destinationPath))
            {
                string content = File.ReadAllText(destinationPath);
                Console.WriteLine($"Tiedoston {destinationPath} sisältö:\n");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"Tiedostoa {destinationPath} ei löytynyt.");
            }
        }
    }
}


/*
Kirjoita ohjelma, joka:

Lukee tiedoston sisällön.
Kirjoittaa saman sisällön uuteen tiedostoon nimeltä kopio.txt.
Vinkki: Käytä File.ReadAllText ja File.WriteAllText.
*/ 