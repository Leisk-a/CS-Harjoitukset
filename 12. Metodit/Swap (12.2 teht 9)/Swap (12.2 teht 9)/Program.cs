using System;

namespace Swap__12._2_teht_9_
{
    internal class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;

            Console.WriteLine($"a = {a}   b = {b}\n");

            Swap(ref a, ref b);

            Console.WriteLine($"a = {a}   b = {b}");
        }
    }
}

/*
Kirjoita metodi Swap, joka vaihtaa kahden muuttujan arvot.

Swap(ref int x, ref int y) // ref viittaus parametrina annettuihin muuttujiin
*/