﻿using System;
using Arrays;

public class multiplicaVetor
{
    static void Main()
    {
        Console.WriteLine("Tamanho do primeiro vetor: ");
        int n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];

        Console.WriteLine("Tamanho do segundo vetor: ");
        int n2 = int.Parse(Console.ReadLine());
        int[] meuVetor2 = new int[n2];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o valor do primeiro vetor para a posição {i}: ");
            meuVetor[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n2; i++)
        {
            Console.WriteLine($"Digite o valor do segundo vetor para a posição {i}: ");
            meuVetor2[i] = int.Parse(Console.ReadLine());
        }
        int resultLength = Math.Min(n, n2);
        int[] result = new int[resultLength];
        for (int i = 0; i < resultLength; i++)
        {
            result[i] = meuVetor[i] * meuVetor2[i];
            Console.WriteLine($"Resultado dos vetores multiplicados: {result[i]} |");
        }
    }
}
