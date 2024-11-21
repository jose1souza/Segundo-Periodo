using System;
using Arrays;


namespace revisao_prova
{
    public class Exercicio1
    {
        static void Main()
        {
            Console.WriteLine("Qntde elementos do vetor: ");

            int tamanho = int.Parse(Console.ReadLine());
            int[] meuVetor = new int[tamanho];

            BibliotecaArray.geraVetor(meuVetor);

            Console.WriteLine("Vetor Gerado");
            BibliotecaArray.mostraVetor(meuVetor);

            int soma = 0;

            for (int i = 0; i < meuVetor.Length; i++)
                soma = soma + meuVetor[i];
            Console.WriteLine($"A soma do vetor é: {soma}");

            Console.ReadKey();
        }
    }
}
