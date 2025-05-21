using System;

namespace TauKes__10._3_teht_12_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] taulu = { 15, 53, 2, 48, 12, 10 };

            int sum = 0;
            for (int i = 0; i < taulu.Length; i++)
            {
                sum += taulu[i];
            }

            int ka = sum / taulu.Length;

            Console.WriteLine($"Lukujen keskiarvo on: {ka}");
        }
    }
}

/*
 Kirjoita ohjelma, joka laskee taulukon lukujen keskiarvon.
 */