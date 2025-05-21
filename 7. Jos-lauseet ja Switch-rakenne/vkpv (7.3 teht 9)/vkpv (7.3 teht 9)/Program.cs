using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkpv__7._3_teht_9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku väliltä 1-7: ");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero >= 1 && numero <= 7)
                {
                    vkpv(numero);
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte. Anna luku 1-7.");
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Syötä luku 1-7.");
            }
        }

        static void vkpv(int numero)
        {
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Maanantai");
                    break;
                case 2:
                    Console.WriteLine("Tiistai");
                    break;
                case 3:
                    Console.WriteLine("Keskiviikko");
                    break;
                case 4:
                    Console.WriteLine("Torstai");
                    break;
                case 5:
                    Console.WriteLine("Perjantai");
                    break;
                case 6:
                    Console.WriteLine("Lauantai");
                    break;
                case 7:
                    Console.WriteLine("Sunnuntai");
                    break;
            }
        }
    }
}


/*
Kirjoita ohjelma, joka ottaa numeron 1–7 ja tulostaa vastaavan viikonpäivän.
*/