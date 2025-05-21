using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salasana__9._2_teht_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salasana = 54;
            int a= -1;
            

            do
            {
                Console.WriteLine("Salasana:");
                string input = Console.ReadLine();
                bool validInput = int.TryParse(input, out a);
                if (salasana == a)
                {
                    Console.WriteLine("Salasana oikein.");
                }
                else
                {
                    Console.WriteLine("Salasana väärin.");
                }
                
            }
            while (salasana != a);
        }
    }
}


// Kirjoita ohjelma, joka kysyy käyttäjältä salasanaa, kunnes käyttäjä syöttää oikean salasanan.