using System;

    public class Exercicio_1181
{
    static void Main()
    {

        int linhaop = int.Parse(Console.ReadLine());

        float[,] matrix = new float[12, 12];

        char letra = char.Parse(Console.ReadLine());

        float soma = 0;
        float media = 0;

        for(int i = 0; i < 12; i++)
        {
            for(int j = 0; j < 12; j++)
            {
                matrix[i,j] = float.Parse(Console.ReadLine());
            }
        }

        if (letra == 'S')
        {
            for (int i = linhaop; i <= linhaop; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                        soma = soma + matrix[linhaop, j];
                }
            }
            Console.WriteLine($"{soma:F1}");
        }
        if (letra == 'M')
        {
            for (int i = linhaop; i <= linhaop; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                        soma = soma + matrix[linhaop, j];
                        media = soma / 12;
                }
            }
            media = soma / 12;
            Console.WriteLine($"{media:F1}");
        }
      }
 }


