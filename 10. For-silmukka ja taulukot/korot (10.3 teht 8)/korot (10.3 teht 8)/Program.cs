using System;
using System.Text;

namespace korot__10._3_teht_8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;
            double korko = 0.05;

            Console.WriteLine("Anna säästetty summa:");
            string input = Console.ReadLine();
            bool validInput = double.TryParse(input, out double i);

            for (int vuosi = 1; vuosi <= 10; vuosi++)
            {
                double tulos = i * ( 1 + korko);

                Console.WriteLine($"Säästetty määrä {vuosi} vuoden aikana: {tulos:C}");

                i = tulos;
            }
        }
    }
}

/*
 Kirjoita ohjelma, joka laskee säästetyn summan arvon korkoa korolle 
 laskettuna 10 vuoden ajan, jos korkoprosentti on 5%.
 */