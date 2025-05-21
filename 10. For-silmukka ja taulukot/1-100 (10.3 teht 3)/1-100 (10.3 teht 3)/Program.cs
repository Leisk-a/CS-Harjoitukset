using System;

namespace _1_100__10._3_teht_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine($"Summa lukujen 1-100 välillä on: {sum}");
        }
    }
}


/*
 Kirjoita ohjelma, joka laskee ja tulostaa lukujen summan välillä 1–100.
 */