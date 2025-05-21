using System;

namespace _2djar__10._3_teht_16_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3]; 

            a[0, 0] = 1;
            a[0, 1] = 2;
            a[0, 2] = 3;
            a[1, 0] = 4;
            a[1, 1] = 5;
            a[1, 2] = 6;
            a[2, 0] = 7;
            a[2, 1] = 8;
            a[2, 2] = 9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}


/*
 Kirjoita ohjelma, joka tallentaa kaksiulotteiseen taulukkoon seuraavat rivit ja tulostaa ne:

1  2  3
4  5  6
7  8  9
 */