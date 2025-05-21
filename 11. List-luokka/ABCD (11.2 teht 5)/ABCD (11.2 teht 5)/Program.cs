using System;
using System.Collections.Generic;

namespace ABCD__11._2_teht_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nimet = new List<string>() { "Ismo", "Okko", "Lauri", "Sofia", "Aapo" };

            nimet.Sort();
            Console.WriteLine("Lajiteltu koko lista (ForEach-metodi):");
            nimet.ForEach(Console.WriteLine);
        }
    }
}


/*
Järjestä nimet aakkosjärjestykseen
Kirjoita ohjelma, joka:


Luo List<string>-listan, jossa on vähintään 5 nimeä.
Lajittelee nimet aakkosjärjestykseen.
Tulostaa nimet järjestyksessä.
 */