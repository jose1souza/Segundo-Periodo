using System;

class URI
{

    static void Main(string[] args)
    {
        int a, b, prod;
        // declarando as variáveis
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        // transformando elas de string para inteiro

        prod = a * b;
        //calculando o produto dos valores

        Console.WriteLine($"PROD = {prod}");
        //mostrando o resultado da produto


    }

}