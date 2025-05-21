using System;

namespace Ympärysmitta
{
    internal class Program
    {
        const double PI = 3.14159;
        static void Main()
        {

            Console.Write("Anna ympyrän halkaisia: ");
            string input = Console.ReadLine();
            bool validInput = double.TryParse(input, out double halkaisia);

            if (validInput)
            {
                double ymitta = PI * halkaisia;
                Console.WriteLine($"Ympärysmitta on: {ymitta}");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }

    }
}
