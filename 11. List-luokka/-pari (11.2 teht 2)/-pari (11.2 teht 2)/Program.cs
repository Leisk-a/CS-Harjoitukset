using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _pari__11._2_teht_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> luvut = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }; 

            luvut.RemoveAll(luku => luku % 2 == 0);

            Console.WriteLine("Parittomat luvut:");
            foreach (int luku in luvut)
            {
                Console.Write(luku + " ");
            }
        }
    }
}


/*
 Poista parilliset luvut
Kirjoita ohjelma, joka:

Luo List<int>-listan, jossa on lukuja 1–20.
Poistaa kaikki parilliset luvut listasta.
Tulostaa jäljelle jääneet luvut.
 */