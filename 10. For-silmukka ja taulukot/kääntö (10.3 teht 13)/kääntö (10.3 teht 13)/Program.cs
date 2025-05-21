using System;

namespace kääntö__10._3_teht_13_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = { 5, 3, 8, 1 };

            Console.Write("Luvut nyt: ");
            for (int i = 0; i < luvut.Length; i++)
            {
                Console.Write(luvut[i]);
                if (i < luvut.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            Array.Reverse(luvut);

            Console.Write("Luvut käännetty: ");
            for (int i = 0; i < luvut.Length; i++)
            {
                Console.Write(luvut[i]);
                if (i < luvut.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}


/*
 Kirjoita ohjelma, joka kääntää taulukon arvot toiseen järjestykseen.
 */