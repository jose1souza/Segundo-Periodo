using Arrays;
using System;

class exercicio3
{
    static double menorVetor(double[] vetor)
    {   // percorrer o vetor e mostrar o menor
        double menor = vetor[0];
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }
        return menor;
    }
    static void Main()
    {
        Console.WriteLine("Tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());
        double[] meuVetor = new double[n];
        BibliotecaArray.geraVetor(meuVetor);
        Console.WriteLine("Vetor gerado: ");
        BibliotecaArray.mostraVetor(meuVetor);
        Console.WriteLine($"\n O menor número do vetor é igual a: {menorVetor(meuVetor):F2}");
        Console.ReadKey();

    }
}