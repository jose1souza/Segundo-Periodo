using System;
using System.IO;

namespace BibliotecaMatriz { 
    class Matrizes
    {
    public static void leia(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int colunas = mat.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.WriteLine($"[{i},{j}]");
                mat[i, j] = int.Parse(Console.ReadLine());
            }// fim do for colunas
        }// fim do for linhas
    }
    // ---------------------------------------- fim do leia
    public static void mostra(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int colunas = mat.GetLength(1);
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"{mat[i, j],3} |");
            } // fim do for colunas
            Console.WriteLine();
        }// fim do for linhas
        // ------------------------------------------ fim do mostra
    }public static void mostraf(double[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{mat[i, j]:F1} |");
                } // fim do for colunas
                Console.WriteLine();
            }
        }
    
        public static void gera(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);

            Random random = new Random();

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    mat[i, j] = random.Next(0, 100);
                }
            }
        }
        public static void geraf(double[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);

            Random random = new Random();
            double num = 5.15;

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    mat[i,j] = random.Next(0, 100);
                    mat[i,j] = mat[i,j] * num;
                } // fim do for colunas

                Console.WriteLine();

            }// fim do for linhas

        }// ------------------------------------------ fim do gera
    }
}



