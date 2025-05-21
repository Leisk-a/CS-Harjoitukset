using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 5, 6, 3, 2, 4, 2, 5, 7, 1, 6 };

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"Lukujen summa: {sum}");
    }
}



/*
Luo lista ja laske summa
Kirjoita ohjelma, joka:

Luo List<int>-tyyppisen listan.
Lisää listaan 10 lukua (1–10).
Laskee ja tulostaa listan lukujen summan.
 */