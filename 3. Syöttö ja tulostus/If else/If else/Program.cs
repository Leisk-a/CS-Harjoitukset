using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä ikäsi:");


            bool validInput = int.TryParse(Console.ReadLine(), out int age);


            if (validInput)
            {
                Console.WriteLine("Ikäsi on " + age + " vuotta.");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen ikä.");
            }
        }
    }
}
