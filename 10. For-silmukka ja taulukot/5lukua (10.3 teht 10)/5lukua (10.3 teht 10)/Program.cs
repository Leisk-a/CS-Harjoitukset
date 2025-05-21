using System;
using System.Diagnostics.CodeAnalysis;

namespace _5lukua__10._3_teht_10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            Console.WriteLine($"Anna ensimmäinen kokonaisluku:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int a);

            Console.WriteLine($"Anna toinen kokonaisluku:");
            string input1 = Console.ReadLine();
            bool validInput1 = int.TryParse(input1, out int b);

            Console.WriteLine($"Anna kolmas kokonaisluku:");
            string input2 = Console.ReadLine();
            bool validInput2 = int.TryParse(input2, out int c);

            Console.WriteLine($"Anna neljäs kokonaisluku:");
            string input3 = Console.ReadLine();
            bool validInput3 = int.TryParse(input3, out int d);

            Console.WriteLine($"Anna viides kokonaisluku:");
            string input4 = Console.ReadLine();
            bool validInput4 = int.TryParse(input4, out int e);

            int[] luvut = new int[5];

            luvut[0] = a;
            luvut[1] = b;
            luvut[2] = c;
            luvut[3] = d;
            luvut[4] = e;

            Console.WriteLine($"{luvut[0]}");
            Console.WriteLine($"{luvut[1]}");
            Console.WriteLine($"{luvut[2]}");
            Console.WriteLine($"{luvut[3]}");
            Console.WriteLine($"{luvut[4]}");
        }
    }
}


/*
 Kirjoita ohjelma, joka pyytää käyttäjältä viisi kokonaislukua ja tallentaa ne taulukkoon. 
 Lopuksi ohjelma tulostaa arvot.
 */