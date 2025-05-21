using System;

namespace valo__4._2_teht_5_
{
    internal class Program
    {
        const double c = 299792458;
        static void Main(string[] args)
        {
            const int c = 299792458;

            Console.WriteLine("Anna sekuntti määrä:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int s);

            if (validInput)
            {
                double mm = c * s ;
                double k = mm / 1000;
                Console.WriteLine($"Valo kulkee {k} kilometriä {s} sekunnissa.");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}