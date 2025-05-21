using System;

namespace Kaava__4._2_teht_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.81;

            Console.Write("Anna putoamisajan arvo sekunteina:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int t);

            if (validInput)
            {   
                double s = 0.5 * g * t * t;
                Console.WriteLine($"Putoamismatka on: {s} metriä");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}

