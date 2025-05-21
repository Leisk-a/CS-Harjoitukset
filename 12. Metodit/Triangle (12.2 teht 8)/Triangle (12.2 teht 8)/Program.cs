using System;

namespace Triangle__12._2_teht_8_
{
    internal class Program
    {
        public static void PrintTriangle(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Virheellinen syöte. Luvun on oltava positiivinen luku.");
                return;
            }

            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n - a; b++)
                {
                    Console.Write(" ");
                }

                for (int c = 1; c <= 2 * a - 1; c++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Anna kolmion korkeus:");
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
        }
    }
}


/*
Kirjoita metodi PrintTriangle, joka saa parametrina 
kokonaisluvun n ja tulostaa kolmion, jossa on n riviä tähtiä.
*/