using System;
using System.Runtime.CompilerServices;

namespace matikka__5._7_teht_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen kokonaisluku:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int k1);

            if (!validInput)
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

            Console.WriteLine("Anna toinene kokonaisluku:");
            string input2 = Console.ReadLine();
            bool validInput2 = int.TryParse(input2, out int k2);

            if (validInput2)
            {
                double summa = k1 + k2;
                double erotus = k1 - k2;
                double tulo = k1 * k2;
                double osamaara = k1 / k2;
                double jakojaannos = k1 % k2;
                Console.WriteLine($"Summa on {k1} + {k2} = {summa}. Erotus on {k1} - {k2} = {erotus}. Tulo on {k1} * {k2} = {tulo}. Osamäärä on {k1} / {k2} = {osamaara}. Jakojäännös on {k1} % {k2} = {jakojaannos}");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

        }
    }
}

/*Kirjoita ohjelma, joka pyytää käyttäjältä kahta kokonaislukua. Laske ja tulosta näiden lukujen:

summa(+),
erotus(-),
osamäärä(/),
jakojäännös(%).*/