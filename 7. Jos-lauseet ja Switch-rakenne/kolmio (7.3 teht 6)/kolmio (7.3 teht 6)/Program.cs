using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolmio__7._3_teht_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ensimmäisen sivun pituus: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Anna toisen sivun pituus: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Anna kolmannen sivun pituus: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c &&
                a + c > b &&
                b + c > a)
            {
                Console.WriteLine("Sivut muodostavat kolmion.");
            }
            else
            {
                Console.WriteLine("Sivut eivät muodosta kolmiota.");
            }
        }
    }
}


/*
Kirjoita ohjelma, joka tarkistaa, muodostavatko kolme käyttäjän 
syöttämää sivun pituutta kelvollisen kolmion.

Kahden sivun yhteinen pituus pitää olla suurempi kuin kolmannen sivun pituus.
 */