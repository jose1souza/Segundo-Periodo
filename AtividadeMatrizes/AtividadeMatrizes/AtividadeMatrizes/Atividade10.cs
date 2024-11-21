using System;
using BibliotecaMatriz;

    internal class Atividade10
    {
    public static void geratropas(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int colunas = mat.GetLength(1);

        Random random = new Random();

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                mat[i, j] = random.Next(0, 101);
            }
        }
    }
    public static void mostratropa(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int colunas = mat.GetLength(1);
        int cont = 1;
        for (int i = 0; i < linhas; i++)
        {
            Console.Write($"Região {cont} ");
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"{mat[i, j],3} |");
            }
            cont++;
            Console.WriteLine();
        }
    }
    public static int[] Soma(int[,] matriz1)
     {
            int lin = matriz1.GetLength(0);
            int cols = matriz1.GetLength(1);
            int[] soma = new int[lin];

            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                soma[i] = matriz1[i, j] + soma[i];
                }
            }
            return soma;
     }
    public static void mostrasoma(int[] soma)
    {
        int cont = 1;

        for (int i = 0; i < soma.Length; i++)
        {
            Console.WriteLine($"Região {cont}: {soma[i]} tropas");
            cont++;
        }
    }

    public static void Main()
        {
            Console.WriteLine("Quantas regiões existem: ");
            int regi = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas cidades existem: ");
            int cida = int.Parse(Console.ReadLine());

            int[,] matrix = new int[regi, cida];

            geratropas(matrix);

            Console.WriteLine("Matriz das Tropas (Quantidade de Tropas por Cidade):");
            mostratropa(matrix);
            Console.WriteLine();
            Console.WriteLine("Força Total das Regiões:");
            int[] somaTropas = Soma(matrix);
            mostrasoma(somaTropas);




    }
}
