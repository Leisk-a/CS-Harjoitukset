using System;

namespace C___F__4._2_teht_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna °C aste jonka haluat kääntää:");
            string input = Console.ReadLine();
            bool validInput = double.TryParse(input, out double c);

            if (validInput)
            {
                double f = (c * 9/5) +32;
                Console.WriteLine($"{c}°C on {f} fahrenheittia");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}

//Pyydä käyttäjältä lämpötila Celsius-asteina ja laske se Fahrenheit-asteiksi.