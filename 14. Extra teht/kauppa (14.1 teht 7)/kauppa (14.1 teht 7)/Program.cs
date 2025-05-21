
/*
Useat kaupparyhmittymät antavat bonusta, kun asiakas keskittää ostoksiaan saman ryhmittymän liikkeisiin. Saat siis tavallaan maksamaasi rahaa takaisin esim. seuraavan taulukon mukaisesti:

 kuukausiostojen määrä vähintään (€) bonus % 
  85     1% 
 170    1,5% 
 340    2% 
 500    3%

Laadi metodi, joka ilmoittaa bonusrahan euroina. Käyttäjä ilmoittaa ohjelmalle kuukausiostojen määrän.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kauppa__14._1_teht_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bonus();
        }

        static void bonus()
        {
            double kkostot;

            while (true)
            {
                Console.Write("Anna kuukausiostojen määrä euroina (negatiivinen lopettaa): ");
                if (!double.TryParse(Console.ReadLine(), out kkostot))
                {
                    Console.WriteLine("Virheellinen syöte. Anna luku.");
                    continue;
                }

                if (kkostot < 0)
                {
                    break;
                }

                double bonusprosentti = bonuspors(kkostot);
                double bonuseur = kkostot * (bonusprosentti / 100);

                Console.WriteLine($"Bonusprosentti: {bonusprosentti}%");
                Console.WriteLine($"Bonus euroina: {bonuseur} euroa");
            }
        }

        static double bonuspors(double kkostot)
        {
            if (kkostot >= 500)
            {
                return 3;
            }
            else if (kkostot >= 340)
            {
                return 2;
            }
            else if (kkostot >= 170)
            {
                return 1.5;
            }
            else if (kkostot >= 85)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
