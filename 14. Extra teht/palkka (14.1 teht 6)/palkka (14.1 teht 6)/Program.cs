
/*
Laadi metodi, joka tulostaa bruttopalkan, verot euroina ja nettopalkan. 
Käyttäjä antaa työtuntien määrän, tuntipalkan sekä veroprosentin. 
Tehtävää toistetaan, kunnes käyttäjä antaa työtuntien määräksi nollan tai negatiivisen luvun. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palkka__14._1_teht_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            print();
        }

        static void print()
        {
            double tyotunnit, tuntipalkka, veroprosentti;

            while (true)
            {
                Console.Write("Anna työtuntien määrä (0 tai pienempi lopettaa): ");
                if (!double.TryParse(Console.ReadLine(), out tyotunnit))
                {
                    Console.WriteLine("Virheellinen syöte. Anna luku.");
                    continue;
                }

                if (tyotunnit <= 0)
                {
                    break;
                }

                Console.Write("Anna tuntipalkka: ");
                if (!double.TryParse(Console.ReadLine(), out tuntipalkka))
                {
                    Console.WriteLine("Virheellinen syöte. Anna luku.");
                    continue;
                }

                Console.Write("Anna veroprosentti: ");
                if (!double.TryParse(Console.ReadLine(), out veroprosentti))
                {
                    Console.WriteLine("Virheellinen syöte. Anna luku.");
                    continue;
                }

                double bruttopalkka = tyotunnit * tuntipalkka;
                double verot = bruttopalkka * (veroprosentti / 100);
                double nettopalkka = bruttopalkka - verot;

                Console.WriteLine($"Bruttopalkka: {bruttopalkka} euroa");
                Console.WriteLine($"Verot: {verot} euroa");
                Console.WriteLine($"Nettopalkka: {nettopalkka} euroa");
            }
        }
    }
}
