using System;
using Biblioteca_Matriz;

namespace revisao_prova
{
    public class Exercicio2
    {
        public static int somatoda(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);
            int soma = 0;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    soma = soma + mat[i, j];
                }// fim for j
            }// fim for i
            return soma;
        }
        public static int somacoluna(int[,] mat, int col)
        {
            int linhas = mat.GetLength(0);
            int soma = 0;
            for (int i = 0; i < linhas; i++)
            {
                soma = soma + mat[i, col];
                Console.WriteLine();
            }// fim for i
            return soma;
        }
        public static int somalinha(int[,] mat, int lin)
        {
            int cols = mat.GetLength (1);
            int soma = 0;
            for (int j = 0; j < cols; j++)
            {
                soma = soma + mat[lin, j];
            }// fim for i
            return soma;
        }
        static void Main()
        {
            Console.WriteLine("Linhas e colunas");

            int linhas = int.Parse(Console.ReadLine());
            int colunas = int.Parse(Console.ReadLine());

            int[,] minhaMatriz = new int[linhas, colunas];

            Matriz.gera(minhaMatriz);
            Console.WriteLine("Matriz Gerada: ");
            Matriz.mostra(minhaMatriz);

            Console.WriteLine("Coluna para somar: ");
            int coluna_soma = int.Parse(Console.ReadLine());
            int resultado_coluna = somacoluna(minhaMatriz, coluna_soma);
            Console.WriteLine($"Soma da coluna {coluna_soma} é: {resultado_coluna}");

            Console.WriteLine("Linha para somar: ");

            int linha_soma = int.Parse(Console.ReadLine());

            int resultado_linha = somalinha(minhaMatriz, linha_soma);

            Console.WriteLine($"Soma da linha {coluna_soma} é: {resultado_linha}");

            Console.ReadKey();

        }
    }
}
