using System;

namespace piste__5._7_teht_9_
{
    internal class Program
    {
        const int ylaX = 10;
        const int alaX = 0;
        const int ylaY = 10;
        const int alaY = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Anna X koordinaatti:");
            string input1 = Console.ReadLine();
            bool validinput1 = int.TryParse(input1, out int a);

            Console.WriteLine("Anna Y koordinaatti:");
            string input2 = Console.ReadLine();
            bool validinput2 = int.TryParse(input2, out int b);

            if (a > alaX && a < ylaX)
            {
                Console.WriteLine("Piste on suorakulmion sisällä: Kyllä");
            }
            else
            {
                Console.Write("Piste on suorakulmion sisällä: Ei");
            }

            if (b > alaY && b < ylaY)
            {
                Console.WriteLine("Piste on suorakulmion sisällä: Kyllä");
            }
            else
            {
                Console.WriteLine("Piste on suorakulmion sisällä: Ei");
            }
        }
    }
}


/*Kirjoita ohjelma, joka tarkistaa, onko käyttäjän syöttämä piste suorakulmion sisällä. Käytä vertailuoperaattoreita.

Suorakulmio määritellään vakioilla:

vasenX = 0, oikeaX = 10, yläY = 10, alaY = 0

Pyydä käyttäjältä pisteen koordinaatit x ja y.

Esim: 

Syötä pisteen x: 5
Syötä pisteen y: 8
Piste on suorakulmion sisällä: Kyllä*/