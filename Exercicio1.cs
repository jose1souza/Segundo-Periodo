using System;
using Arrays;
class Exercicio1
{
    static int somaVetor(int[] vetor)
    {   // percorrer o vetor e somar. retorne a soma
        int soma = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
             soma = soma + vetor[i];
        }
        return soma;
    }
        static void Main()
        {
        Console.WriteLine("Tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];
        BibliotecaArray.geraVetor(meuVetor);
        Console.WriteLine("Vetor gerado: ");
        BibliotecaArray.mostraVetor(meuVetor);
        Console.WriteLine($"\n A soma do vetor é igual a: {somaVetor(meuVetor)}");
        Console.ReadKey();

    }
  }
