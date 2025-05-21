using System;

namespace Fibi__12._2_teht_7_
{
    internal class Program
    {
        public static int Fibi(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fibi(n - 1) + Fibi(n - 2);
        }

        public static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine("Fibonacci sarjan " + n + " luku on: " + Fibi(n));
        }
    }
}


/*
Kirjoita metodi Fibonacci, joka palauttaa Fibonacci-sarjan n:nnen luvun.
*/