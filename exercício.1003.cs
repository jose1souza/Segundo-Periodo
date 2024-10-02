using System;

class URI
{

    static void Main(string[] args)
    {
        int a, b, soma;
        // declarando as variáveis
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        // transformando elas de string para inteiro

        soma = a + b;
        //calculando a soma dos valores

        Console.WriteLine($"SOMA = {soma}");
        //mostrando o resultado da soma


    }

}