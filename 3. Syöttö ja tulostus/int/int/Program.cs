using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuinka usein treenaat viikossa?:");
            int viikko = int.Parse(Console.ReadLine());

            Console.WriteLine("Kuinka monta kuukautta olet treenannut?:");
            int kuukausi = int.Parse(Console.ReadLine());

            Console.WriteLine("Kuinka paljon painat nyt?:");
            double paino = double.Parse(Console.ReadLine());

            Console.WriteLine("Treenaat " + viikko + " kertaa viikossa ja olet treenannut jo " + kuukausi + " kuukautta ja painat tällähetkellä " + paino + ". Jatka samaan malliin!");
        }
    }
}
