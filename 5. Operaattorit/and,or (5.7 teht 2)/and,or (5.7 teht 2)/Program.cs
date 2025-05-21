using System;

namespace and_or__5._7_teht_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen luku:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int e);

            if (!validInput)
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

            Console.WriteLine("Anna toinen luku:");
            string input2 = Console.ReadLine();
            bool validInput2 = int.TryParse(input2, out int t);

            if (validInput2)
            {
                Console.WriteLine($"Onko luvut yhtäsuuria: { e == t}");
                Console.WriteLine($"Onko luvut erisuuria: {e != t}");
                Console.WriteLine($"Onko ensimmäinen luku suurempi kuin toinen: {e > t}");
                Console.WriteLine($"Onko ensimmäinen luku pienempi kuin toinen: {e < t}");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
        }
    }
}


//Kirjoita ohjelma, joka pyytää käyttäjältä kahta lukua ja tarkistaa, ovatko ne:

//yhtä suuria(==),
//erisuuria(!=),
//ensimmäinen suurempi kuin toinen (>),
//ensimmäinen pienempi kuin toinen (<).
//Esim:

//Syötä ensimmäinen luku: 5
//Syötä toinen luku: 10
//Onko luvut yhtä suuria? Ei
//Onko ensimmäinen suurempi? Ei
//Onko ensimmäinen pienempi? Kyllä