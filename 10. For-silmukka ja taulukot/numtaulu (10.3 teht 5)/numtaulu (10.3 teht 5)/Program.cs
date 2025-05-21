using System;

namespace numtaulu__10._3_teht_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


/*
Kirjoita ohjelma, joka tulostaa seuraavanlaisen taulukon käyttäen for-silmukkaa:

1 2 3 4 5
2 4 6 8 10
3 6 9 12 15
4 8 12 16 20
5 10 15 20 25
 */