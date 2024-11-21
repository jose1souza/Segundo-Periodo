using System;
class Program
{
    static float ConverterParaFahrenheit(float cel)
    {
        float resultado;
        resultado = ((cel * 9 / 5) + 32);
        return resultado;
        // fim da função fatorial
    }
    static void Main()
    {
        float n1;
        // declarando váriaveis
        Console.WriteLine("Entre com um valor em graus Celcius: ");
        n1 = float.Parse(Console.ReadLine());
        // lendo valor
        float res = ConverterParaFahrenheit(n1);
        // chamando a função

        Console.WriteLine($"{res} é o valor em Fahrenheit de {n1} grau celciu(s)");
        // mostrando o resultado

        Console.ReadKey();


    } // fim do main
} // fim do programa
