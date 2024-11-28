using System;
using BibliotecaMatriz;

    internal class Atividade11
    {
        public static int DiagonalPrincipal(int[,] matrix)
        {
            int linhas = matrix.GetLength(0);
            int soma1 = 0;
            for (int i = 0; i < linhas; i++)
            {
                Console.Write($"{matrix[i, i]} |");
                soma1 = matrix[i, i] + soma1;
            }return soma1;
        }
        public static int DiagonalSecundaria(int[,] matrix)
        {
            int linhas = matrix.GetLength(0);
            int colunas = matrix.GetLength(1);
            int j = colunas - 1;
            int soma2 = 0;
            for (int i = 0; i < linhas; i++)
            {
                Console.Write($"{matrix[i, j]} |");
                soma2 = soma2 + matrix[i, j];
                j--;
            }return soma2;
        }
    static void Main()
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
            int soma1 = DiagonalPrincipal(matrix);

            Console.WriteLine();

            Console.WriteLine("Diagonal Secundária:");
            int soma2 = DiagonalSecundaria(matrix);

            if(soma1 > soma2)
            {
                Console.WriteLine();
                Console.WriteLine("O maior tesouro está na diagonal primária, vamos para lá!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("O maior tesouro está na diagonal secundária, vamos para lá!");
            }
        }
        else
        {
            Console.WriteLine("Não é possível apresentar dados para esta dimensão");
        }
        Console.ReadKey();
    }
}
