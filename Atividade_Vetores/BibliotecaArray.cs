using System;

namespace Arrays
{
    public class BibliotecaArray
    {
        public static void LeiaVetor(int[] vetor)
        {
            // lendo vetor
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]");
                vetor[i] = int.Parse(Console.ReadLine());
            } // fim do for
        }// fim da função leia vetor

        public static void LeiaVetor(double[] vetor)
        {
            // lendo vetor
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]");
                vetor[i] = double.Parse(Console.ReadLine());
            } // fim do for
        }// fim da função leia vetor double

        public static void GeraVetor(int[] vetor)
        {
            Random random = new Random(); // gerador de números
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100);
            }
        } // fim da função gera vetor
        public static void GeraVetor(double[] vetor)
        {
            Random random = new Random(); // gerador de números
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100) + random.NextDouble();
            }
        } // fim da função gera vetor

        public static void MostraVetor(int[] vetor)
        {
            // mostra vetor
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($" | {vetor[i]}");
                // mostrando valores do vetor
            }
        } // fim da função mostra vetor

        public static void MostraVetor(double[] vetor)
        {
            // mostra vetor
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($" | {vetor[i]:F2}");
                // mostrando valores do vetor
            }
        } // fim da função mostra vetor

        public static int SomaVetor(int[] vetor)
        {   // percorrer o vetor e somar. retorne a soma
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma = soma + vetor[i];
            }
            return soma;
        }

    }
}
