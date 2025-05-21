using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testi_2
{
    internal class Program
    {
        class Auto
        {
            // Yksityiset kentät
            private string merkki;
            private int vuosi;

            // Propertyt julkisilla get- ja set-menetelmillä
            public string Merkki
            {
                get { return merkki; }
                set { merkki = value; }
            }

            public int Vuosi
            {
                get { return vuosi; }
                set
                {
                    if (value > 1885)  // Ensimmäinen auto valmistettiin vuonna 1886
                        vuosi = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Merkki = "Lada";
            auto.Vuosi = 1986;

            Console.WriteLine(auto.Merkki);
            Console.WriteLine(auto.Vuosi);
           
        }
    }
}


/*
TESTI
*/