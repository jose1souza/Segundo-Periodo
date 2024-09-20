using System;

class URI
{

    static void Main(string[] args)
    {
        int senha;
        senha = int.Parse(Console.ReadLine());
        do
        {
            if (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            if (senha == 2002)
            {
                Console.WriteLine("Acesso Permitido");
            }
        } while (senha != 2002);
    }

}