using System;

public class Exercicio1172
{
    static void Main()
    {
        int[] vetor = new int[10];
        for (int i = 0; i < 10; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
            if (vetor[i] <= 0)
            {
                vetor[i] = 1;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"X[{i}] = {vetor[i]}");
        }
    }
}


