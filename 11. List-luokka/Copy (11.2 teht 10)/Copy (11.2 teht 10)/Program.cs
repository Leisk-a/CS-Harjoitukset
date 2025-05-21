using System;
using System.Collections.Generic;

public class KopioiLista
{
    public static void Main(string[] args)
    {
        List<int> alkuperainenLista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        List<int> kopioLista = new List<int>(alkuperainenLista);

        alkuperainenLista.Add(11);
        alkuperainenLista.Add(12);

        Console.WriteLine("Alkuperäinen lista:");
        foreach (int luku in alkuperainenLista)
        {
            Console.Write(luku + " ");
        }

        Console.WriteLine("\nKopioitu lista:");
        foreach (int luku in kopioLista)
        {
            Console.Write(luku + " ");
        }

        Console.WriteLine();
    }
}


/*
Kopioi lista
Kirjoita ohjelma, joka:


Luo List<int>-listan, jossa on 10 lukua.
Kopioi listan uuteen listaan.
Muokkaa alkuperäistä listaa lisäämällä siihen lukuja.
Tulostaa molemmat listat ja osoittaa, että ne ovat eri kopioita.
*/