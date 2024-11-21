using System;
using System.IO;

namespace Biblioteca_Matriz
{
    class Matriz
    {
        public static void leia(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);
            for(int i = 0; i < linhas; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write($"Digite para [{i},{j}]:");
                    mat[i,j]=int.Parse(Console.ReadLine());
                }// fim for j
            }// fim for i

        }// fim leia
        //--------------------------------------------------
        public static void gera(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);
            Random random = new Random();
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < cols; j++)
                    mat[i, j] = random.Next(0,100);

        }// fim gera
        //-----------------------------------------------------
        public static void mostra(int[,] mat) {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);
            for (int i = 0;i < linhas; i++)
            {
                for (int j = 0;j < cols; j++)
                {
                    Console.Write($"{mat[i,j],3} |");
                }// fim for j
                Console.WriteLine();
            }// fim for i
        }// fim mostra



    }
}
