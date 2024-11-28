using System;
using BibliotecaMatriz;

    internal class Atividade6
    {
        public static int[,] Soma(int[,] matriz1, int[,] matriz2)
        {
            int lin = matriz1.GetLength(0);
            int cols = matriz1.GetLength(1);
            int[,] soma = new int[lin, cols];

            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    soma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            return soma;
        }

        static void Main()
        {
            Console.WriteLine("Linhas e colunas da primeira matriz: ");
            int linha1 = int.Parse(Console.ReadLine());
            int coluna1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Linhas e colunas da segunda matriz: ");
            int linha2 = int.Parse(Console.ReadLine());
            int coluna2 = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[linha1, coluna1];
            int[,] matrix2 = new int[linha2, coluna2];

            if (linha1 == linha2 && coluna1 == coluna2)
            {
                Console.WriteLine("As duas matrizes: ");
                Matrizes.gera(matrix1);
                Matrizes.gera(matrix2);
                Matrizes.mostra(matrix1);
                Console.WriteLine();
                Matrizes.mostra(matrix2);
                Console.WriteLine();

            Console.WriteLine("A soma das matrizes de ordem igual vai ser: \n");
                int[,] resultado = Soma(matrix1, matrix2);
                for (int i = 0; i < resultado.GetLength(0); i++)
                {
                    for (int j = 0; j < resultado.GetLength(1); j++)
                    {
                        Console.Write($"{ resultado[i, j],3} | ");
                }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Não é possível somar matrizes de ordem diferente!!");
            }
            Console.ReadKey();
        }
    }
