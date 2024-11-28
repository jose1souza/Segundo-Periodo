using System;
using biblioteca;
class Program
{
    static int menu()
    {
        Console.WriteLine("/t*** Calculadora C# ***\n");
        Console.WriteLine("1-Somar");
        Console.WriteLine("2-Subtrair");
        Console.WriteLine("3-Dividir");
        Console.WriteLine("4-Multiplicar");
        Console.WriteLine("Digite uma opção: ");
        int opcao = int.Parse(Console.ReadLine());
        return opcao;
    }
    static void Main()
    {
        do
        {
            int opcao = menu();
            Console.WriteLine("Digite dois valores: ");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1: // soma
                    double res = Calculadora.soma(num1, num2);
                    Console.WriteLine($"Resultado:{res:F2}");
                    break;
                case 2: // subtrair
                    res = Calculadora.sub(num1, num2);
                    Console.WriteLine($"Resultado:{res:F2}");
                    break;
                case 3: // dividir
                    res = Calculadora.div(num1, num2);
                    Console.WriteLine($"Resultado:{res:F2}");
                    break;
                case 4: // multiplicar
                    res = Calculadora.multi(num1, num2);
                    Console.WriteLine($"Resultado: {res:F2}");
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }// fim switch
            Console.ReadKey();
            Console.Clear();
        } while (true); // fim do do while


    }
}
