using System;

namespace Su_pie__10._3_teht_11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko = { 5, -12, 3, 8, -1, 9 };

            int suurin = taulukko[0];
            int pienin = taulukko[0];

            for (int i = 0; i < taulukko.Length; i++)
            {
                if (taulukko[i] > suurin)
                {
                    suurin = taulukko[i];
                }

                if (taulukko[i] < pienin)
                {
                    pienin = taulukko[i];
                }
            }

            Console.WriteLine($"Suurin arvo: {suurin}");
            Console.WriteLine($"Pienin arvo: {pienin}");
        }
    }
}


/*
 Kirjoita ohjelma, joka löytää suurimman ja pienimmän arvon taulukosta.
 */