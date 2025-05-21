
/*
Kirjoita ohjelma, joka arpoo luvun väliltä 1-10000 ja käyttäjä yrittää arvata lukuja, kunnes arvaa oikein. 
Jokaisen väärän arvauksen jälkeen ohjelmaa opastaa "suurempi" tai "pienempi". Lopuksi tulostetaan arvausten määrä.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arpa__14._1_teht_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int luku = rand.Next(1, 10001);
            int maara = 0;

            Console.WriteLine("Arvaa luku väliltä 1-10000.");

            while (true)
            {
                Console.Write("Anna arvauksesi: ");

                if (int.TryParse(Console.ReadLine(), out int arvaus))
                {
                    maara++;

                    if (arvaus == luku)
                    {
                        Console.WriteLine($"Oikein! Arvasit luvun {luku} {maara} kerralla.");
                        break;
                    }
                    else if (arvaus < luku)
                    {
                        Console.WriteLine("Luku on suurempi.");
                    }
                    else
                    {
                        Console.WriteLine("Luku on pienempi.");
                    }
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte. Anna luku.");
                }
            }
        }
    }
}
