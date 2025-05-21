using System;
using System.Collections.Generic;


namespace Kauppalist__11._2_teht_11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string toiminto = "empty";
            List<string> kauppalist = new List<string>();
            do
            {

                Console.WriteLine("\nAnna toiminto add/remove/print: \nPoistuessa kirjoita exit.");
                toiminto = Console.ReadLine();


                if (toiminto == "add")
                {
                    Console.WriteLine("\nAnna lisättävä tuote: ");
                    string lisattava = Console.ReadLine();
                    bool validInput = true;

                    if (validInput)
                    {
                        kauppalist.Add(lisattava);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nVirheellinen syöte. ");
                    }
                }
                if (toiminto == "remove")
                {
                    Console.WriteLine("\nAnna poistettava tuote: ");
                    string poistettava = Console.ReadLine();
                    bool validInput = true;

                    if (validInput)
                    {
                        kauppalist.Remove(poistettava);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nVirheellinen syöte / Tai tuotetta ei ole. \n");
                    }
                }
                if (toiminto == "print")
                {
                    kauppalist.ForEach(Console.WriteLine);
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte");
                }

            }
            while (toiminto != "exit");

            Console.WriteLine("Poistuit listasta. \nLista: ");

            kauppalist.ForEach(Console.WriteLine);
        }
    }
}


/*
Simuloi kauppalista
Kirjoita ohjelma, joka:


Luo List<string>-listan, johon käyttäjä voi lisätä tuotteita (kauppalista).
Mahdollistaa tuotteiden lisäämisen, poistamisen ja listan tulostamisen.
Lopettaa toiminnan, kun käyttäjä valitsee "poistu"-vaihtoehdon.
 */