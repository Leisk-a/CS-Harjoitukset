using System;

namespace fibi__8._2_teht_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            int a = 0;
            int b = 1;

            Console.WriteLine(a);
            Console.WriteLine(b);

            int i = 2;

            while (i < 10)
            {
                f = a + b;
                Console.WriteLine(f);

                a = b;
                b = f;
                i++;
            }

        }
    }
}



/* 
 Kirjoita ohjelma, joka tulostaa Fibonacci-sarjan ensimmäiset 10 lukua: 
 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.
*/