using System;

namespace Sk_pintala_4._2_teht_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna suorakulmion leveys:");
            string input = Console.ReadLine();
            bool validInput = double.TryParse(input, out double l);

            if (!validInput)
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

            Console.Write("Anna suorakulmion korkeus:");
            string input2 = Console.ReadLine();
            bool validInput2 = double.TryParse(input2, out double k);

            if (validInput2)
            {
                double ala = l * k;
                Console.WriteLine($"Suorakulmion pintaala on {ala}.");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

        }
    }
}

// Määrittele muuttujat suorakulmion leveyden ja korkeuden tallentamiseen. Pyydä käyttäjältä arvot näihin metreinä ja laske suorakulmion pinta-ala.
