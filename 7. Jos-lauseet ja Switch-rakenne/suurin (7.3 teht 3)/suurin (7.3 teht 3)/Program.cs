using System;

namespace suurin__7._3_teht_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ensimmäinen luku: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Anna toinen luku: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Anna kolmas luku: ");
            double c = double.Parse(Console.ReadLine());

            double tulos = a;

            if (b > tulos)
            {
                tulos = b;
            }

            if (c > tulos)
            {
                tulos = c;
            }

            Console.WriteLine("Suurin luku on: " + tulos);
        }
    }
}


/*
Kirjoita ohjelma, joka pyytää käyttäjältä kolme lukua ja kertoo, mikä niistä on suurin.
 */