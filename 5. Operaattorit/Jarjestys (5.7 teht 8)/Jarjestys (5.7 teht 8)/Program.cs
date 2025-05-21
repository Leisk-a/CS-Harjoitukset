using System;
using System.ComponentModel.Design;

namespace Jarjestys__5._7_teht_8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen kokonaisluku:");
            string input1 = Console.ReadLine();
            bool validInput1 = int.TryParse(input1, out int a);

            Console.WriteLine("Anna toinen kokonaisluku:");
            string input2 = Console.ReadLine();
            bool validInput2 = int.TryParse(input2, out int b);

            Console.WriteLine("Anna kolmas kokonaisluku:");
            string input3 = Console.ReadLine();
            bool validInput3 = int.TryParse(input3, out int c);

            if (validInput1 && validInput2 && validInput3);
            {
                if (a < b && b < c)
                    Console.WriteLine("Kasvava järjestys: Kyllä");
                else
                    Console.WriteLine("Kasvava järjestys: Ei");
                if (a > b && b > c)
                    Console.WriteLine("Laskeva järjestys: Kyllä");
                else
                    Console.WriteLine("Laskeva järjestys: Ei");
                if (a == b && b == c)
                    Console.WriteLine("Kaikki samoja: Kyllä");
                else
                    Console.WriteLine("Kaikki samoja: Ei");
            }

        }
    }
}


/*Kirjoita ohjelma, joka pyytää käyttäjältä kolmea kokonaislukua. Tarkista seuraavilla ehdoin:

Onko kaikki luvut kasvavassa järjestyksessä?
Onko kaikki luvut laskevassa järjestyksessä?
Ovatko kaikki luvut samoja?
Käytä loogisia ja vertailuoperaattoreita.

Esim:

Syötä ensimmäinen luku: 3
Syötä toinen luku: 5
Syötä kolmas luku: 7
Kasvava järjestys: Kyllä
Laskeva järjestys: Ei
Kaikki samat: Ei*/