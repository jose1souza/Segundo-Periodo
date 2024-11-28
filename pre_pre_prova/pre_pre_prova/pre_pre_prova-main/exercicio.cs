using System;
using Arrays;

class exercicio
{
    public static void mostra(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1);
        int cont = 0;
        for (int i = 0; i < linhas; i++)
        {
            Console.Write("[");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{mat[i, j],3} ");
                if(cont < 4)
                {
                    Console.Write(",");
                    cont++;
                }
            }
            cont = 0;
            Console.Write($"]\n");
        }// fim for i
    }// fim mostra
    public static void gera(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1);
        Random random = new Random();
        for (int i = 0; i < linhas; i++)
            for (int j = 0; j < cols; j++)
                mat[i, j] = random.Next(0, 51);

    }
    static void Main() 
    {
        int[,] matrix = new int[5,5];
        int ocorrencias = 0;

        exercicio.gera(matrix);
        exercicio.mostra(matrix);

        Console.WriteLine("\nMatriz de Ocorrências de Crimes:");

        int maior = 0;
        int menor = (50 * 5) + 1;
        int regmenor = 0;
        int regmaior = 0;
        int cont = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],3} ");
                if(cont < 4)
                {
                    Console.Write(",");
                    cont++;
                }
                ocorrencias = ocorrencias + matrix[i, j];
            }
            cont = 0;
            Console.Write($"] -> Total na região {i}: ");
            Console.Write($"{ocorrencias}\n");
            

            if (ocorrencias > maior)
            {
                maior = ocorrencias;
                regmaior = i;
            }
            if (ocorrencias < menor)
            {
                menor = ocorrencias;
                regmenor = i;
            }
            ocorrencias = 0;
        }

        Console.WriteLine("\nAnálise de Ocorrências:");
        Console.WriteLine($"- Região onde ocorreram mais crimes: **{maior} crimes** na Região {regmaior}.");
        Console.WriteLine($"- Região onde ocorreram menos crimes: **{menor} crimes** na Região {regmenor}.");
        Console.ReadKey();

    }
 }

