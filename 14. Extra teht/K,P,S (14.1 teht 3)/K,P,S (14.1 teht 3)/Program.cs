
/*
Tee "kivi,paperi, sakset"-peli, jossa toinen pelaaja on tietokone.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_P_S__14._1_teht_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random satunnainen = new Random();

            while (true)
            {
                Console.WriteLine("Valitse: 1 = kivi, 2 = paperi, 3 = sakset (exit = lopeta)");
                Console.Write("Sinä: ");

                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                if (input != "1" && input != "2" && input != "3")
                {
                    Console.WriteLine("Virheellinen syöte. Yritä uudelleen.");
                    continue;
                }

                int tietokone = satunnainen.Next(1, 4);

                Console.WriteLine("Tietokoneen: " + TulostaValinta(tietokone));
                Console.WriteLine("Sinä: " + TulostaValinta(int.Parse(input)));

                Voittaja(int.Parse(input), tietokone);
            }
        }

        static string TulostaValinta(int valinta)
        {
            switch (valinta)
            {
                case 1: return "kivi";
                case 2: return "paperi";
                case 3: return "sakset";
                default: return "virhe";
            }
        }

        static void Voittaja(int input, int tietokone)
        {
            if (input == tietokone)
            {
                Console.WriteLine("Tasapeli!");
            }
            else if (
                (input == 1 && tietokone == 3) ||
                (input == 2 && tietokone == 1) ||
                (input == 3 && tietokone == 2)
            )
            {
                Console.WriteLine("Sinä voitit!");
            }
            else
            {
                Console.WriteLine("Tietokone voitti!");
            }
        }
    }
}
