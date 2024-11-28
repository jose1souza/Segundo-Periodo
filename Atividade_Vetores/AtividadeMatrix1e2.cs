 using System;
using BibliotecaMatriz;
using System.IO;
    
    class AtividadeMatrix1e2
 {
    public static int MaiorMatrix(int[,] matrix)
    {
        int maior = matrix[0, 0];

        int linhas = matrix.GetLength(0); // pega linhas
        int cols = matrix.GetLength(1); // pega colunas

        for (int i = 0; i < linhas; i++)
        { 
            for(int j = 0; j < cols; j++)
            {
                if(matrix[i, j] > maior)
                {
                     maior = matrix[i, j];
                }
            }
        }return maior;
    }public static int MenorMatrix(int[,] matrix)
    {
        int menor = matrix[0, 0];

        int linhas = matrix.GetLength(0); // pega linhas
        int cols = matrix.GetLength(1); // pega colunas

        for (int i = 0; i < linhas; i++)
        { 
            for(int j = 0; j < cols; j++)
            {
                if(matrix[i, j] < menor)
                {
                     menor = matrix[i, j];
                }
            }
        }return menor;
    }
    static void Main()
    {

        Console.WriteLine("Digite a quantidade de linhas e a quantidade de colunas: ");

        int linha = int.Parse(Console.ReadLine());
        int coluna = int.Parse(Console.ReadLine());

        int[,] matrix = new int[linha, coluna]; // criando a matriz

        Matrizes.gera(matrix);
        Console.WriteLine("Matriz Gerada: ");
        Matrizes.mostra(matrix);

        int maiorValor = MaiorMatrix(matrix);
        int menorValor = MenorMatrix(matrix);

        Console.WriteLine($"\n O maior número da matriz é igual a: {maiorValor}");
        Console.WriteLine($"\n O menor número da matriz é igual a: {menorValor}");
        Console.ReadKey();
     }
 }
 
 