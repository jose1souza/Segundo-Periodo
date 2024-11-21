using System;
class Program
{
    static double CalcularPotencia(int num,int x)
    {
        return Math.Pow(num, x); ;
        // fim da função potencia
    }
        static void Main()
        {
            int n1, ex;
            // declarando váriaveis

            Console.WriteLine("Entre com um valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor do expoente: ");
            ex = int.Parse(Console.ReadLine());
            // lendo valores

            double res = CalcularPotencia(n1, ex);
            // chamando a função potencia

            Console.WriteLine($"{res} é o resultado de {n1} elevado a {ex}");
            // mostrando o resultado

            Console.ReadKey();


        } // fim do main
    } // fim do programa
