using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romnum__7._3_teht_14_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna pisteen x-koordinaatti:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Anna pisteen y-koordinaatti:");
            double y = double.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Piste on alussa.");
            }
            else if (x == 0)
            {
                Console.WriteLine("Piste on y-akselilla.");
            }
            else if (y == 0)
            {
                Console.WriteLine("Piste on x-akselilla.");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Piste on I:ssa.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Piste on II:ssa.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Piste on III:ssa.");
            }
            else
            {
                Console.WriteLine("Piste on IV:ssa.");
            }
        }
    }
}


/*
Kirjoita ohjelma, joka tarkistaa, missä neljänneksessä (I, II, III, IV) käyttäjän antama piste (x, y) sijaitsee tasossa.
*/