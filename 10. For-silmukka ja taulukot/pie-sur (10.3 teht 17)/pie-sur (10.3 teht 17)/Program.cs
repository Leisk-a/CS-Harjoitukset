using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pie_sur__10._3_teht_17_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numerot = { 153, 12, 3, 7, 7 };

            Array.Sort(numerot);

            for (int i = 0; i < numerot.Length; i++)
            {
                Console.Write(numerot[i]);

                if (i < numerot.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

        }
    }
}


/*
Kirjoita ohjelma, joka järjestää taulukon luvut pienimmästä suurimpaan.

Array.Sort(...
 */