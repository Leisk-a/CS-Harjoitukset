using System;
using System.Text;

namespace esimkoodit__6._4_teht_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double luku = 10587.95;

            Console.WriteLine($"Luku: {luku:F2}");
        Valuutta:

            double hinta = 99.99;
            Console.OutputEncoding = Encoding.Default;

            Console.WriteLine($"Hinta: {hinta:C}");
        Prosentit:

            double osuus = 0.85;

            Console.WriteLine($"Osuus: {osuus:P}"); 

            DateTime paivamaara = DateTime.UtcNow;

            Console.WriteLine($"Tänään on: {paivamaara:dd.MM.yy}"); 
            Console.WriteLine($"Kellonaika: {paivamaara:HH:mm}");   
        }
    }
}
