using System;
class Program
{
    static bool EhPrimo(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
                // número não é primo
            }
        }
        return true;
    }// o número é primo
     // fim da função primo
    static void Main()
    {
        int n1;
        // declarando váriaveis
        Console.WriteLine("Entre com um valor: ");
        n1 = int.Parse(Console.ReadLine());
        // lendo valor para verificar se é primo
        bool primo = EhPrimo(n1);
        // chamando a função

        if (primo == true)
        {
            Console.WriteLine($"{n1} é um número primo");
        }
        else
        {
            Console.WriteLine($"{n1} não é um número primo");
        }
        // mostrando o resultado

        Console.ReadKey();


    } // fim do main
} // fim do programa
