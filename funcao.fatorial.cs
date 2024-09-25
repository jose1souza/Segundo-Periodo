using System;
class Program
{
    static int CalcularFatorial(int num)
    {
        int resultado = 1;
        for (int i = 2; i <= num; i++)
        {
            resultado = resultado * i;
        }
        return resultado;
        // fim da função fatorial
    }
    static void Main()
    {
        int n1;
        // declarando váriaveis
        Console.WriteLine("Entre com um valor: ");
        n1 = int.Parse(Console.ReadLine());
        // lendo valor
        int res = CalcularFatorial(n1);
        // chamando a função

        Console.WriteLine($"{res} é o fatorial de {n1}");
        // mostrando o resultado

        Console.ReadKey();


    } // fim do main
} // fim do programa
