using System;

namespace esimkoodit__6._4_teht_3_
{
    internal class Program
    {
        static void Main()
        {
            string text = "Hei,\nTämä on esimerkki \"escape-merkeistä\" C#:ssa.\n\t- Tabulaattori\n\t- Rivinvaihto\n \nTes\tti\t\tTAB \n\t56 \f59";
            Console.WriteLine(text);
        }
    }
}
