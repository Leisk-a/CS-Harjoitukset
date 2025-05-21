using System;

namespace Säästö__8._2_teht_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Anna summa:");
            string input = Console.ReadLine();
            bool validInput = double.TryParse(input, out double sum);
            double korotettu = 0;
            Console.WriteLine("Anna korko:");
            string input2 = Console.ReadLine();
            bool validInput2 = double.TryParse(input2, out double korko);

            Console.WriteLine("Anna tavoitesumma:");
            string input3 = Console.ReadLine();
            bool validInput3 = double.TryParse(input3, out double tavoitesum);
            if (validInput && validInput2 && validInput3)
            {
                while (sum < tavoitesum)
                {
                    korotettu = sum * korko;
                    sum += korotettu;

                    Console.WriteLine($"Vuosittainen korko: {korotettu} \nSäästetty summa: {sum}");
                } 
            }

            else
            {
                Console.WriteLine("Virheellinen luku.");
            }
        }
    }
}


/*
Kirjoita ohjelma, joka laskee säästetyn summan ja koron vuosittain, kunnes säästö ylittää tavoitesumman.
 */