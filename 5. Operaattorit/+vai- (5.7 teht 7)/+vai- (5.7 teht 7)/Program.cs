using System;

namespace _vai___5._7_teht_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku jonka haluat tarkistaa:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int a);

            if (validInput)
            {
                string result = (a > 0) ? "Posittiivinen" : (a < 0) ? "Negatiivinen" : "Nolla";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}
