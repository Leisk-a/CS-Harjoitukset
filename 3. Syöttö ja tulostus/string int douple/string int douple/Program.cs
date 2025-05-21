using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_int_douple
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Syötä nimesi:");
            string name = Console.ReadLine();


            Console.WriteLine("Syötä ikäsi:");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine("Syötä pituutesi:");
            double height = double.Parse(Console.ReadLine());


            Console.WriteLine("Hei " + name + "!");
            Console.WriteLine("Ikäsi on " + age + " vuotta.");
            Console.WriteLine("Pituutesi on " + height + " metriä.");
        }
    }
}
