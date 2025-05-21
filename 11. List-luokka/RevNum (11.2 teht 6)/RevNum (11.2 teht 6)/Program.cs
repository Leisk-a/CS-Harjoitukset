using System;
using System.Collections.Generic;

namespace RevNum__11._2_teht_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numerot = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } ;
            numerot.Reverse();
            numerot.ForEach(x => Console.Write(x+" "));
        }
    }
}


/*
Listan käänteinen järjestys
Kirjoita ohjelma, joka:

Luo List<int>-listan, johon lisätään lukuja 1–10.
Kääntää listan järjestyksen.
Tulostaa listan sekä ennen että jälkeen käännön.
 */