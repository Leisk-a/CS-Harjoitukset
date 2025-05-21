using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä nimesi:");
            string name = Console.ReadLine();

            Console.WriteLine("Syötä lempivärisi:");
            string vari = Console.ReadLine();

            Console.WriteLine("Hei, " + name + " ja lempivärisi on " + vari + "!");
        }
    }
}
