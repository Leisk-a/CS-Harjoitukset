using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laskin__7._3_teht_10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ensimmäinen luku: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Virheellinen syöte. Syötä luku.");
                return;
            }

            Console.Write("Anna toinen luku: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Virheellinen syöte. Syötä luku.");
                return;
            }

            Console.Write("Anna laskutoimitus (+, -, *, /): ");
            string laskutoimitus = Console.ReadLine();

            double tulos = 0;

            switch (laskutoimitus)
            {
                case "+":
                    tulos = a + b;
                    break;
                case "-":
                    tulos = a - b;
                    break;
                case "*":
                    tulos = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Nollalla ei voi jakaa.");
                        return;
                    }
                    tulos = a / b;
                    break;
                default:
                    Console.WriteLine("Virheellinen laskutoimitus.");
                    return;
            }

            Console.WriteLine($"Tulos: {tulos}");
        }
    }
}

/*
Kirjoita ohjelma, joka pyytää käyttäjältä kaksi lukua ja laskutoimituksen (+, -, *, /) sekä suorittaa valitun laskutoimituksen.
*/