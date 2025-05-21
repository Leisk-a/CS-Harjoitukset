using System;

namespace Square__12._2_teht_3_
{
    internal class Program
    {
        static int Square(int num)
        {
            return num * num;
        }

        static void Main()
        {
            Console.WriteLine("Anna luku:");
            int luku = int.Parse(Console.ReadLine());
            int nelio = Square(luku);
            Console.WriteLine($"Luvun {luku} neliö on {nelio}");
        }
    }
}


/*
Kirjoita metodi Square, joka ottaa kokonaisluvun parametrina ja palauttaa sen neliön.
 */