using System;

namespace sum__12._2_teht_4_
{
    internal class Program
    {
        static int sum(int luku1, int luku2)
        {
            return luku1 + luku2;
        }
        static void Main()
        {
            Console.WriteLine("Anna ensimmäinen kokonaisluku:");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen kokonaisluku:");
            int luku2 = int.Parse(Console.ReadLine());
            int summa = sum(luku1, luku2);
            Console.WriteLine($"Lukujen summa on {summa} \n{luku1} + {luku2} = {summa}");
        }
    }
}


/*
Kirjoita metodi Sum, joka ottaa kaksi kokonaislukua ja palauttaa niiden summan.
 */