using System;

namespace keskiarvo__9._2_teht_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double maara = 0; 

            while (true)
            {
                Console.WriteLine("Anna lukuja jonka keskiarvolasketaan:");
                string input = Console.ReadLine();
                bool validInput = double.TryParse(input, out double i);
                if (i < 0 || !validInput)
                    break;
                sum += i;
                maara++; 
            }
            if (maara > 0)
            {
                double keskiarvo = sum / maara; 
                Console.WriteLine($"Lukujen keskiarvo on: {keskiarvo}");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte.");
            }
        }
    }
}


/* 
Kirjoita ohjelma, joka laskee käyttäjän syöttämien positiivisten lukujen keskiarvon.
Lopeta, kun käyttäjä syöttää negatiivisen luvun.
 */