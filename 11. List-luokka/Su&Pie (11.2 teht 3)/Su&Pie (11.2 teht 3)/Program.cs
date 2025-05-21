using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Su_Pie__11._2_teht_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> luvut = new List<int>();

            Console.WriteLine("Syötä 5 lukua:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Luku {i + 1}: ");
                int luku = int.Parse(Console.ReadLine());
                luvut.Add(luku);
            }

            int suurin = luvut[0];
            int pienin = luvut[0];

            for (int i = 1; i < luvut.Count; i++)
            {
                if (luvut[i] > suurin)
                {
                    suurin = luvut[i];
                }

                if (luvut[i] < pienin)
                {
                    pienin = luvut[i];
                }
            }

            Console.WriteLine($"Suurin luku: {suurin}");
            Console.WriteLine($"Pienin luku: {pienin}");
        }
    }
}


/*
Hae suurin ja pienin luku
Kirjoita ohjelma, joka:

Luo List<int>-tyyppisen listan, johon käyttäjä voi syöttää 5 lukua.
Tulostaa listan suurimman ja pienimmän luvun.
 */