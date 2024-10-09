using System;
class Program
{
    static void Main()
    {
        string texto;
        int cont = 0;

        Console.Write("Entre com um texto: ");
        texto = Console.ReadLine();

        Console.Write("Entre com uma letra: ");
        char letra = Console.ReadLine()[0];

        string textoM = texto.ToUpper();
        char letraM = char.ToUpper(letra);

        for (int i = 0; i < textoM.Length; i++)
        {
            if (textoM[i] == letraM)
            {
                cont++;
            }
        }
        Console.Write($"No texto existe {cont} vezes a letra digitada");

        Console.ReadKey();
    }
}