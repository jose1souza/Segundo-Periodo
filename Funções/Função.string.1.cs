using System;
class Program
{
    static void Main()
    {
        string texto, texto2;

        Console.Write("Entre com um texto: ");
        texto = Console.ReadLine();

        Console.Write("Entre com outro texto: ");
        texto2 = Console.ReadLine();

        string textoM = texto.ToUpper();
        string textoM2 = texto2.ToUpper();


        int retorno = string.Compare(textoM, textoM2);
        if (retorno == 0)
        {
            Console.WriteLine("As strings são iguais");
        }
        else
        {
            Console.WriteLine("As strings não são iguais");
        }

        int compriT1 = texto.Length;
        int compriT2 = texto2.Length;

        if (compriT1 == compriT2)
        {
            Console.WriteLine($"As strings tem a mesma quantidade de letras que é {compriT1}");
        }
        else if(compriT1 > compriT2)
        {
            Console.WriteLine($"A primeira string é maior e tem {compriT1 - compriT2} a mais que a segunda");
        }
        else
        {
            Console.WriteLine($"A segunda string é maior e tem {compriT2 - compriT1} a mais que a primeira");
        }

        Console.ReadKey();
    }
}
