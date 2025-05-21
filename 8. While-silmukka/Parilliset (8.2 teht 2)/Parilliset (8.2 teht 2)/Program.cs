using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parilliset__8._2_teht_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 100)
            {
                i++;
                if (i % 2 == 1)
                if (i % 3 == 1)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}

// Kirjoita ohjelma, joka tulostaa kaikki parilliset tai kolmella jaolliset luvut väliltä 1–100.