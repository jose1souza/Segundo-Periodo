using BibliotecaMatriz;
using System;
    internal class AtividadeMatrix4e5
    {
    public static void DiagonalPrincipal(int[,] matrix)
    { 
        int linhas = matrix.GetLength(0);
        for (int i = 0; i < linhas; i++)
        {
            Console.Write($"{matrix[i,i]} |");
        }
    }
    public static void DiagonalSecundaria(int[,] matrix)
    { 
        int linhas = matrix.GetLength(0);
        int colunas = matrix.GetLength(1);
        int j = colunas - 1;
        for (int i = 0;i < linhas; i++)
        {
            Console.Write($"{matrix[i, j]} |");
            j--;
        }
    }
    public static void Main()
    {
        int linhas, cols;
        Console.WriteLine("Digite a quantidade de linhas e colunas:");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        if (linhas == cols)
        {
            int[,] matrix = new int[linhas, cols];// criando a matriz
            Matrizes.gera(matrix);
            Console.WriteLine("Matriz Gerada");
            Matrizes.mostra(matrix);
            Console.WriteLine("Diagonal Principal:");
            DiagonalPrincipal(matrix);
            Console.WriteLine();
            Console.WriteLine("Diagonal Secundária:");
            DiagonalSecundaria(matrix);
        }
        else
        {
            Console.WriteLine("Não é possível apresentar dados para esta dimensão");
        }
        Console.ReadKey();
    }
 }
