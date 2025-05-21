
/*
Tee lottopeli (pallot 1-39), jossa arvotaan 7 lottopalloa. 
Tee myös oma rivi. Ohjelma tarkistaa ja tulostaa, kuinka monta meni oikein.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto__14._1_teht_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lotto = arpa();
            List<int> input = user();

            int oikein = Tarkistus(lotto, input);

            Console.WriteLine("Arvotut lottopallot: " + string.Join(", ", lotto));
            Console.WriteLine("Sinun rivisi: " + string.Join(", ", input));
            Console.WriteLine($"Oikein meni: {oikein}");
        }

        static List<int> arpa()
        {
            Random satunnainen = new Random();
            List<int> lotto = new List<int>();

            while (lotto.Count < 7)
            {
                int uusi = satunnainen.Next(1, 40); 

                if (!lotto.Contains(uusi)) 
                {
                    lotto.Add(uusi);
                }
            }

            lotto.Sort(); 
            return lotto;
        }

        static List<int> user()
        {
            List<int> input = new List<int>();

            Console.WriteLine("Anna lottorivi, 7 lukua (1-39), erotettuna pilkulla:");
            string rivi = Console.ReadLine();

            string[] luvut = rivi.Split(',');

            if (luvut.Length != 7)
            {
                Console.WriteLine("Virhe: Rivissä tulee olla 7 lukua.");
                return user(); 
            }

            foreach (string luku in luvut)
            {
                if (int.TryParse(luku.Trim(), out int numero))
                {
                    if (numero >= 1 && numero <= 39 && !input.Contains(numero))
                    {
                        input.Add(numero);
                    }
                }
                else
                {
                    Console.WriteLine("Virhe: Syötä vain kokonaislukuja.");
                    return user(); 
                }
            }

            input.Sort(); 
            return input;
        }

        static int Tarkistus(List<int> lotto, List<int> input)
        {
            return lotto.Intersect(input).Count();
        }
    }
}
