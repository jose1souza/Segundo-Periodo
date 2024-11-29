using System;
using Arrays;

internal class VetorDado
{
    static void Main()
    {
        int tentativa = 1;
        int ten1 = 0, ten2 = 0, ten3 = 0, ten4 = 0, ten5 = 0, ten6 = 0;
        Console.WriteLine("Digite quantas vezes deseja lançar o dado: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        for (int i = 0; i < vetor.Length; i++)
        {
            do
            {
                Console.WriteLine($"Digite o número que saiu na tentativa {tentativa} (de 1 a 6): ");
                vetor[i] = int.Parse(Console.ReadLine());
            } while (vetor[i] < 1 || vetor[i] > 6);
            tentativa++;

            if (vetor[i] == 1)
            {
                ten1++;
            }
            else if (vetor[i] == 2)
            {
                ten2++;
            }
            else if (vetor[i] == 3)
            {
                ten3++;
            }
            else if (vetor[i] == 4)
            {
                ten4++;
            }
            else if (vetor[i] == 5)
            {
                ten5++;
            }
            else
            {
                ten6++;
            }
        }
        Console.WriteLine($"Vezes que o número 1 apareceu: {ten1}");
        Console.WriteLine($"Vezes que o número 2 apareceu: {ten2}");
        Console.WriteLine($"Vezes que o número 3 apareceu: {ten3}");
        Console.WriteLine($"Vezes que o número 4 apareceu: {ten4}");
        Console.WriteLine($"Vezes que o número 5 apareceu: {ten5}");
        Console.WriteLine($"Vezes que o número 6 apareceu: {ten6}");
        Console.ReadKey();
    }
}

