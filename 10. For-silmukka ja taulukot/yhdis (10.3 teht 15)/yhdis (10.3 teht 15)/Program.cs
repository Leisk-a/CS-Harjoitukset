using System;

namespace yhdis__10._3_teht_15_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numerot = { 3, 4 };


            int[] numerot2 = { 1, 2 };
            int[] numerot3 = new int[numerot.Length + numerot2.Length];
            Array.Copy(numerot, numerot3, numerot.Length );
            Array.Copy(numerot2, 0, numerot3, numerot.Length, numerot2.Length);


            for (int i = 0; i < numerot3.Length; i++)
            {
                
                    Console.Write(numerot3[i]+", ");
                
            }
            Console.WriteLine();
        }
    }
}


/*
Kirjoita ohjelma, joka yhdistää kahden taulukon arvot yhdeksi.

Array.Copy(...
 */