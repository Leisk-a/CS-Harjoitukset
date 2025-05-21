
/*
Kirjoita ohjelma (metodi), joka laskee suorakulmaisen kolmion hypotenuusan pituuden, kun kateettien pituudet annetaan. Käytä Math-luokan metodeja Pow, Sqrt ja Round.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hypote__14._1_teht_8_
{
    internal class Program
    {
        public static double Hypotenuusa(double a, double b)
        {
            double hnelio = Math.Pow(a, 2) + Math.Pow(b, 2);
            double hypotenuusa = Math.Sqrt(hnelio);

            return Math.Round(hypotenuusa, 2);
        }

        public static void Main(string[] args)
        {
            double a = 3;
            double b = 4;

            double hypotenuusa = Hypotenuusa(a, b);
            Console.WriteLine($"Hypotenuusan pituus on: {hypotenuusa}");
        }
    }
}
