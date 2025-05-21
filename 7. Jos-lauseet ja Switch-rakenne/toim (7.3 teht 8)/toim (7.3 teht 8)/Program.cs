using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toim__7._3_teht_8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("1. Laske 1 + 1");
            Console.WriteLine("2. Laske 5 x 52");
            Console.WriteLine("3. Poistu");

            int valinta = int.Parse(Console.ReadLine());

            switch (valinta)
            {
                case 1:

                    int vastaus = 1 + 1;
                    Console.WriteLine($"{vastaus}");
                    break;

                case 2:
                    
                    int vastaus2 = 5 * 52;
                    Console.WriteLine($"{vastaus2}");
                    break;

                case 3:

                    break;

                default:

                    Console.WriteLine("Virheellinen syöte.");
                    break;
            }
        }
    }
}
