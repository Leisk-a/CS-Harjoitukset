using System;

namespace PelkFor__10._3_teht_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for (int i = 2; i <= 20; i = i + 2) 
            {
                Console.WriteLine($"Luku: {i}");
            }
        }
    }
}


/*
 Kirjoita ohjelma, joka tulostaa kaikki parilliset luvut väliltä
 1–20 pelkästään for-silmukkaa käyttäen (ei %-operaattoria).
 */