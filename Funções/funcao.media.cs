using System;
class Program
{
    static float media(float a, float b, float c)
    {
        float resultado;
        resultado = (a + b + c) / 3;
        return resultado;
    } // fim da função media
    static void Main()
    {
        float n1, n2, n3, res;
        // declarando váriaveis

        Console.WriteLine("Entre com o primeiro valor: ");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o segundo valor: ");
        n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o terceiro valor: ");
        n3 = float.Parse(Console.ReadLine());
        // lendo os valores para calcular a media

        res = media(n1, n2, n3);
        // chamando a função

        Console.WriteLine("Média: " + res);
        // mostrando o resultado

        Console.ReadKey();


    } // fim do main
} // fim do programa
