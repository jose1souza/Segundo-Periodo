using System;

class URI
{

    static void Main(string[] args)
    {
        float idade, soma = 0, media, cont = 0;
        idade = float.Parse(Console.ReadLine());
        do
        {
            if (idade >= 0)
            {
                soma = soma + idade;
                cont++;
            }
            idade = float.Parse(Console.ReadLine());
        } while (idade >= 0);
        media = soma / cont;
        Console.WriteLine($"{media:F2}");
    }

}