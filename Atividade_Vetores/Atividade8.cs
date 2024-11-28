using System;
using BibliotecaMatriz;

    internal class Atividade8
    {
    static void Main()
        {
            int[,] matrix = new int[5, 8];

            Random random = new Random();

            matrix[random.Next(0, 5), random.Next(0, 8)] = 1;

        int n = 0;
        do
        {
            n = int.Parse(Console.ReadLine());
        } while (n < 2 || n > 500000);

        int x = 0;
        int y = 0;
        Matrizes.mostra(matrix);

            while (n > 0)
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
              if (matrix[x, y] == 1)
                {
                Console.WriteLine("1");
                }
                n--;
            }
        if(n == 0) 
        Console.WriteLine("0");

    }
    }
