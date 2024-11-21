using System;
using System.Runtime.Serialization;

class URI
{

    static void Main(string[] args)
    {

        int a,cont = 0;
        float b = 0,soma = 0;
        a = 0;
        while (a < 6)
        {
            b = float.Parse(Console.ReadLine());
            a++;
                if(b > 0){
                cont++;
                soma = soma + b;
            }
        }
        Console.WriteLine($"{cont} valores positivos");
        Console.WriteLine($"{soma / cont:F1}");

    }

}