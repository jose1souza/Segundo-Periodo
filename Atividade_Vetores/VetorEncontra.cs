using System;
using Arrays;


    public class VetorEncontra
{
    static void Main()
    {
            Console.WriteLine("Escreva o tamanho do vetor");
            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite os números inteiros do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

            Console.WriteLine("Digite o número que você deseja saber quantas vezes apareceu: ");
            int num = int.Parse(Console.ReadLine());
            int cont = 0;

        for (int i = 0; i < n; i++)
        {
            if (vetor[i] == num)
            {
                cont++;
            }
        }

        for (int i = 0; i < n; i++) 
        {
            Console.Write($"{vetor[i]} |");
        }
        Console.WriteLine($"o número {num} apareceu {cont} vezes no vetor");
        Console.ReadKey();
    }
}

