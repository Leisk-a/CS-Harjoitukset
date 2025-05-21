using System;

namespace Laskuja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä ensimmäinen luku:");
            bool validInput = int.TryParse(Console.ReadLine(), out int ensimmainen);


            if (!validInput)
            {
                Console.WriteLine("Virheellinen luku. Anna kokonais luku.");
            }

            Console.WriteLine("Syötä toinen luku:");

            bool validInput2 = int.TryParse(Console.ReadLine(), out int toinen);


            if (!validInput2)
            {
                Console.WriteLine("Virheellinen luku. Anna kokonais luku.");
            }
            
            int summa = ensimmainen + toinen;
            int erotus = ensimmainen - toinen;
            int tulos = ensimmainen * toinen;

            Console.WriteLine("Summa on " + ensimmainen + " + " + toinen + " = " + summa );
            Console.WriteLine("Erotus on " + ensimmainen + " - " + toinen + " = " + erotus );
            Console.WriteLine("Näiden tulos on " + ensimmainen + " * " + toinen + " = " + tulos );

        }
    }
}
