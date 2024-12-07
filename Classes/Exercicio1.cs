using System;


/*class TipoBanda
{
    //criando uma classe TipoBanda
    public string nome;
    public string genero;
    public int integrantes;
    public int ranking;
}*/
    public class Exercicio1
    {
        static void Main()
        {


        Console.WriteLine("*** Sistema de Cadastro de Bandas ***");
        // criando uma variavél  do tipo banda
        TipoBanda banda1 = new TipoBanda();

        //inserindo valor para a variavél banda
        Console.WriteLine("Dados da banda: ");

        Console.Write("Nome: ");
        banda1.nome = Console.ReadLine();

        Console.Write("Genero: ");
        banda1.genero = Console.ReadLine();

        Console.Write("Número de integrantes: ");
        banda1.integrantes = int.Parse(Console.ReadLine());

        Console.Write("Ranking da banda: ");
        banda1.ranking = int.Parse(Console.ReadLine());

        Console.WriteLine("Nome da banda: " + banda1.nome);
        Console.WriteLine("Genero da banda: " + banda1.nome);
        Console.WriteLine("Número de integrantes da banda: " + banda1.nome);
        Console.WriteLine("Ranking da banda: " + banda1.nome);

        Console.ReadKey();
        }
    }

