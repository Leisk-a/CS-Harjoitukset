using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirjau__7._3_teht_12_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tunnus = "testi";
            string salasana = "123";

            Console.Write("Syötä käyttäjätunnus: ");
            string input = Console.ReadLine();

            Console.Write("Syötä salasana: ");
            string input2 = Console.ReadLine();

            if (input == tunnus && input2 == salasana)
            {
                Console.WriteLine("Pääsy käyttäjätietoihin.");
            }
            else
            {
                Console.WriteLine("Salasana tai käyttäjätunnus virheellinen.");
            }
        }
    }
}


/*
Kirjoita ohjelma, joka pyytää käyttäjältä käyttäjätunnusta ja salasanaa. 
Vain jos molemmat ovat oikein, tulostat "pääsy käyttäjätietoihin" . 
Muussa tapauksessa ohjelma tulostaa "salasana tai käyttäjätunnus virheellinen"
*/