using System;

namespace paine__4._2_teht_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double p = 1.225;
            const double g = 9.81;

            Console.Write("Anna korkeuden muutos:");
            string input = Console.ReadLine();
            bool validInput = double.TryParse(input, out double h);

            if (validInput)
            {
                double P = p * g * h;
                Console.WriteLine($"Paineen muutos on: {P}");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

        }
    }
}


// Määrittele vakiona ilman tiheys ρ=1.225 kg/m^3 ja painovoiman kiihtyvyys g=9.81 m/s^2. Pyydä käyttäjältä korkeuden muutos h ja laske paineen muutos kaavalla:
// ΔP = ρ×g×h