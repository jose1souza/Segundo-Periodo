﻿using System;
using Arrays;
internal class VetorInverso
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de letras que você quer no vetor: ");
        int n = int.Parse(Console.ReadLine());

        char[] letras = new char[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Agora digite as letras: ");
            letras[i] = char.Parse(Console.ReadLine());
        }
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine($"Letras do vetor inversamente: {letras[i]}");
        }
    }
}
