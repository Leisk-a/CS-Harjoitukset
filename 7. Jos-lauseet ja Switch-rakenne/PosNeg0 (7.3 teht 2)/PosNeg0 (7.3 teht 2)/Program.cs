using System;

namespace PosNeg0__7._3_teht_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku jonka haluat tarkistaa:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int a);

            if (validInput)
            {
                string result = (a > 0) ? "Posittiivinen" : (a < 0) ? "Negatiivinen" : "Nolla";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}


//Kirjoita ohjelma, joka tarkistaa, onko käyttäjän syöttämä luku positiivinen, negatiivinen vai nolla.