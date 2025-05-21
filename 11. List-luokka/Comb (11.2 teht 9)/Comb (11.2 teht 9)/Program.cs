using System;
using System.Collections.Generic;

namespace Comb__11._2_teht_9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3 };
            List<int> list2 = new List<int>() { 4, 5, 6, 1 };

            foreach (int numerot2 in list2)
            {
                list1.Add(numerot2);
            }

            List<int> list1yhdi = new List<int>();
            foreach (int luku in list1)
            {
                if (!list1yhdi.Contains(luku))
                {
                    list1yhdi.Add(luku);
                }
            }

            foreach (int numerot3 in list1yhdi)
            {
                Console.Write(numerot3+" ");
            }
        }
    }
}


/*
Yhdistä kaksi listaa
Kirjoita ohjelma, joka:


Luo kaksi erillistä List<int>-listaa, joissa on lukuja.
Yhdistää listat yhdeksi listaksi.
Tulostaa yhdistetyn listan ilman duplikaatteja.
*/