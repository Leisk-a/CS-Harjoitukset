using System;

namespace pari__5._7_teht_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int luku);

            if (validInput)
            {
                if (luku % 2 == 0)
                    Console.WriteLine($"Luku on parillinen.");
                else
                    Console.WriteLine("Luku on pariton");
                if (luku % 3 == 0)
                    Console.WriteLine("Luku on jaollinen kolmella.");
                else
                    Console.WriteLine("Luku on ei ole jaollinen kolmella");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}