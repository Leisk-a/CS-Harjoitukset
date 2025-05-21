using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caculate__12._2_teht_6_
{
    internal class Program
    {
        static int CalculateSum(int[] luvut)
        {
            int sum = 0;
            foreach (int luku in luvut)
            {
                sum += luku;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[] taulukko = { 1, 2, 3, 4, 5 };
            int sum = CalculateSum(taulukko);
            Console.WriteLine($"Taulukon lukujen summa on: {sum}");
        }
    }
}


/*
Kirjoita metodi CalculateSum, joka saa parametrina kokonaislukutaulukon ja palauttaa sen summan.
*/