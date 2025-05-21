using System;

namespace tarki__10._3_teht_14_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna etsittävä luku:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int b);

            int[] taulukko = { 5, 12, 3, 8, 1, 9 };
            int luku = b;

            bool a = false;
            for (int i = 0; i < taulukko.Length; i++)
            {
                if (taulukko[i] == luku)
                {
                    a = true;
                    break;
                }
            }

            if (a)
            {
                Console.WriteLine($"{luku} on taulukossa.");
            }
            else
            {
                Console.WriteLine($"{luku} ei ole taulukossa.");
            }

            for (int i = 0; i < taulukko.Length; i++)
            {
                Console.Write(taulukko[i]);

                if (i < taulukko.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
