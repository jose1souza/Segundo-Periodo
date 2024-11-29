
using Arrays;
using System;

public class MenorVetor
{
    static double MeVetor(double[] vetor)
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
        BibliotecaArray.GeraVetor(meuVetor);
        Console.WriteLine("Vetor gerado: ");
        BibliotecaArray.MostraVetor(meuVetor);
        Console.WriteLine($"\n O menor número do vetor é igual a: {MeVetor(meuVetor):F2}");
        Console.ReadKey();

    }
}
