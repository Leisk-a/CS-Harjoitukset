using System;

namespace hinta__4._2_teht_4_
{
    internal class Program
    {
        const double alv_prosentti = 25.5 ;
        static void Main(string[] args)
        {
            Console.WriteLine("Anna tuotteen veroton hinta:");
            string input = Console.ReadLine();
            bool validInput = double.TryParse(input, out double vh);

            if (validInput)
            {
                double alv_maara = vh * (alv_prosentti / 100);
                double kh = vh + alv_maara;
                Console.WriteLine($"Kokonais hinta on {kh}€");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}

// Määrittele vakiona arvonlisävero (esim. 25,5%). Pyydä käyttäjältä tuotteen hinta ilman veroa ja laske kokonaishinta.
