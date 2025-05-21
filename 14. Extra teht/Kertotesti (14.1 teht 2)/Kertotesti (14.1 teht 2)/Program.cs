
/*
Tee kertotaulutesti. Kysy testaajalta nimi. Testi jatkuu kunnes vastataan väärin tai max 10 kierrosta. 
Käytä kokonaislukuja 1-15. Käyttäjän nimi ja tulos ja päivämäärä kirjataan tiedostoon.
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertotesti__14._1_teht_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna nimi: ");
            string nimi = Console.ReadLine();

            int a = 0;
            int b = 10;
            Random random = new Random();

            for (int i = 0; i < b; i++)
            {
                int luku1 = random.Next(1, 16);
                int luku2 = random.Next(1, 16);
                Console.Write($"{luku1} x {luku2} = ");
                if (int.TryParse(Console.ReadLine(), out int vastaus) && vastaus == luku1 * luku2)
                {
                    a++;
                    Console.WriteLine("Oikein!");
                }
                else
                {
                    Console.WriteLine("Väärin.");
                    break;
                }
            }

            string tulos = $"{nimi}, {a} oikein {DateTime.Now}\n";
            File.AppendAllText("kertotaulutulokset.txt", tulos);

            Console.WriteLine($"Testi päättyi. Sait {a} oikein.");
        }
    }
}
