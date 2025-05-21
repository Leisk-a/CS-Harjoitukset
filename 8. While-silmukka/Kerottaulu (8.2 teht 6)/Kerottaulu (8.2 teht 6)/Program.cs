using System;

namespace Kerottaulu__8._2_teht_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int a);

            int sum = 1;

            while (sum <= 10)
            {
                int tulo = a * sum;

                if (!validInput)
                    break;
                sum++;

                Console.WriteLine($"{tulo}");
            }
        }
    }
}

/*
 Kirjoita ohjelma, joka tulostaa käyttäjän syöttämän luvun kertotaulun väliltä 1–10.
 */