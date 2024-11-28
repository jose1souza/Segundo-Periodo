using System;
using BibliotecaMatriz;

    public class Atividade7
    {
    public static double[,] Soma(double[,] matriz1, double[,] matriz2)
    {
        int lin = matriz1.GetLength(0);
        int cols = matriz1.GetLength(1);
        double[,] soma = new double[lin, cols];

        for (int i = 0; i < lin; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                soma[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }
        return soma;
    }
    public static double[,] Sub(double[,] matriz1, double[,] matriz2)
    {
        int lin = matriz1.GetLength(0);
        int cols = matriz1.GetLength(1);
        double[,] sub = new double[lin, cols];

        for (int i = 0; i < lin; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sub[i, j] = matriz1[i, j] - matriz2[i, j];
            }
        }
        return sub;
    }
    public static void SomaConstante(double[,] matriz1, double[,] matriz2,double constante)
    {
        int lin = matriz1.GetLength(0);
        int cols = matriz1.GetLength(1);

        for (int i = 0; i < lin; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matriz1[i, j] = matriz1[i, j] + constante;
                matriz2[i, j] = matriz2[i, j] + constante;
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("Linhas e colunas da primeira matriz: ");
        int linha1 = int.Parse(Console.ReadLine());
        int coluna1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Linhas e colunas da segunda matriz: ");
        int linha2 = int.Parse(Console.ReadLine());
        int coluna2 = int.Parse(Console.ReadLine());

        double[,] matrix1 = new double[linha1, coluna1];
        double[,] matrix2 = new double[linha2, coluna2];

        Matrizes.geraf(matrix1);
        Matrizes.geraf(matrix2);

        char letra = 'z';

        if (linha1 == linha2 && coluna1 == coluna2)
        {
            while(letra != 'e')
            {
                Console.WriteLine("Digite a(somar as duas matrizes) b(subtrair a primeira matriz da segunda)" +
            " , c(adicionar uma constante as duas matrizes) ou d(imprimir as matrizes ou e(parar)");

                letra = char.Parse(Console.ReadLine());
                letra = char.ToLower(letra);

                if (letra == 'a')
                {
                    Console.WriteLine("A soma das matrizes de ordem igual vai ser: ");
                    double[,] resultado = Soma(matrix1, matrix2);
                    for (int i = 0; i < resultado.GetLength(0); i++)
                    {
                        for (int j = 0; j < resultado.GetLength(1); j++)
                        {
                            Console.Write($"{resultado[i, j],3:F1} | ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (letra == 'b')
                {
                    Console.WriteLine("A subtração da primeira matriz pela segunda vai ser: ");
                    double[,] resultado = Sub(matrix1, matrix2);
                    for (int i = 0; i < resultado.GetLength(0); i++)
                    {
                        for (int j = 0; j < resultado.GetLength(1); j++)
                        {
                            Console.Write($"{resultado[i, j],3:F1} | ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (letra == 'c')
                {
                    Console.WriteLine("Digite a constante a ser adicionada: ");
                    double constante = float.Parse(Console.ReadLine());
                    SomaConstante(matrix1, matrix2, constante);
                    Console.WriteLine("Matrizes com a constante: ");
                    Console.WriteLine("Primeira matriz: ");
                    Matrizes.mostraf(matrix1);
                    Console.WriteLine("Segunda matriz: ");
                    Matrizes.mostraf(matrix2);

                }

                else if (letra == 'd')
                {
                    Console.WriteLine("Primeira matriz: ");
                    Matrizes.mostraf(matrix1);
                    Console.WriteLine("Segunda matriz: ");
                    Matrizes.mostraf(matrix2);
                }
            }
        }
        else
        {
            Console.WriteLine("Matrizes de ordem diferente só resta a opção d(imprimir as matrizes): ");
            Console.WriteLine("Primeira matriz: ");
            Matrizes.mostraf(matrix1);
            Console.WriteLine("Segunda matriz: ");
            Matrizes.mostraf(matrix2);
        }
    }
}

