using System;
using System.Text;

namespace esimkoodit__6._4_teht_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hei maailma!");


            // Lisää tekstiä loppuun
            sb.Append(" Kuinka voit?");

            sb.Append(" Toivottavasti hyvin!");
            Console.WriteLine(sb.ToString());

            // Lisää tekstiä tiettyyn kohtaan
            sb.Insert(4, "kaunis ");

            sb.Insert(11, "pallo ");
            Console.WriteLine(sb.ToString());

            // Korvaa tekstiä
            sb.Replace("Hei", "Terve");

            sb.Replace("maailma!", "planeetta!");
            Console.WriteLine(sb.ToString());

            sb.Remove(6, 7); 


            Console.WriteLine(sb.ToString());
        }
    }
}
