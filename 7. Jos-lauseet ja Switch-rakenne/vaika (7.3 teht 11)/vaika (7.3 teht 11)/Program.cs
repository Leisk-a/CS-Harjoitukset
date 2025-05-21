using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaika__7._3_teht_11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna kuukauden numero 1-12: ");

            if (int.TryParse(Console.ReadLine(), out int kuukausi))
            {
                if (kuukausi >= 1 && kuukausi <= 12)
                {
                    vaika(kuukausi);
                }
                else
                {
                    Console.WriteLine("Virheellinen kuukauden numero. Syötä luku väliltä 1-12.");
                }
            }
            else
            {
                Console.WriteLine("Virheellinen kuukauden numero. Syötä luku väliltä 1-12.");
            }
        }

        static void vaika(int kuukausi)
        {
            switch (kuukausi)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Talvi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Kevät");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Kesä");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Syksy");
                    break;
            }
        }
    }
}


/*
Kirjoita ohjelma, joka pyytää kuukauden numeron ja tulostaa siihen liittyvän vuodenajan.
*/