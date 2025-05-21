using System;

namespace IsEven__12._2_teht_5_
{
    internal class Program
    {
        static bool IsEven(int luku)
        {
            return luku % 2 == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku:");
            int luku = int.Parse(Console.ReadLine());

            if (IsEven(luku))
            {
                Console.WriteLine("true.");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}


/*
Kirjoita metodi IsEven, joka ottaa kokonaisluvun ja palauttaa true, 
jos luku on parillinen, ja false, jos se ei ole.
*/