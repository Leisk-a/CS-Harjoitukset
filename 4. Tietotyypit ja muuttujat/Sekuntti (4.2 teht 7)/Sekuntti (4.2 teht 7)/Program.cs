using System;

namespace Sekuntti__4._2_teht_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna sekunttimäärä jonka haluat muuntaa:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int si);

            if (validInput)
            {
                int h = si / 3600;
                int m = (si - (h * 3600)) / 60;
                int s = si - ((h * 3600) + (m * 60));
                Console.WriteLine($"{si} sekunttia on {h} tuntia, {m} minuuttia, {s} sekunttia.");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}

//Pyydä käyttäjältä sekuntien määrä ja laske, kuinka monta tuntia, minuuttia ja sekuntia tämä vastaa.