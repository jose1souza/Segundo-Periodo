﻿using System;
using Arrays;
internal class VetorSorteio
{
    static void Main()
    {
        Console.WriteLine("Digite um valor entre 1 e 99 para tentar acertar: ");
        int n = int.Parse(Console.ReadLine());
        Random random = new Random();
        Random random2 = new Random();
        int[] vetor = new int[random.Next(100, 1000)];
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = random2.Next(1, 100);
            if (n == vetor[i])
            {
                Console.WriteLine($"O número digitado está no vetor na posição: {i} | ");
            }
        }
    }
}
