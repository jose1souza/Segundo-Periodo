using System;
using System.ComponentModel.DataAnnotations;
class Livros
{
    public string titulo;
    public string autor;
    public int ano;
}

public class Exercicio_2
{
    // função que adiciona os livros
    static void AddLivros(List<Livros> listaDeLivros)
    {
        //função que adiciona os atributos da classe

        //inicio uma variavél Livros
        Livros novosLivros = new Livros();

        // preenchendo a lista
        Console.WriteLine("*** Dados para a prateleira de livros ***");
        Console.Write("Titulo do Livro: ");
        novosLivros.titulo = Console.ReadLine();

        Console.Write("Autor do livro: ");
        novosLivros.autor = Console.ReadLine();

        Console.Write("Ano do Livro: ");
        novosLivros.ano = int.Parse(Console.ReadLine());

        // conferindo a quantidade de caracteres
        bool Confer = true;

        // do titulo
        if (novosLivros.titulo.Length > 30)
        {
            Confer = false;
            Console.WriteLine("O título possui mais que 30 caracteres");
        }

        // do autor
        if (novosLivros.autor.Length > 15)
        {
            Confer = false;
            Console.WriteLine("O nome do autor possui mais que 15 caracteres");
        }
        if (Confer == true)
        {
            // adicionar os dados na lista se tudo estiver correto
            listaDeLivros.Add(novosLivros);
            Console.WriteLine("Dados adicionados com sucesso!!");
        }
    }
    // função mostra os livros
    static void MostraLivros(List<Livros> listaDeLivros)
    {
        Console.WriteLine("*** Bandas Cadastradas ***");
        for (int i = 0; i < listaDeLivros.Count; i++)
        {
            // mostrando os dados de cada Livro
            Console.WriteLine($"*** Livro {i + 1} ***");
            Console.WriteLine($"Titulo: {listaDeLivros[i].titulo}");
            Console.WriteLine($"Autor: {listaDeLivros[i].autor}");
            Console.WriteLine($"Ano: {listaDeLivros[i].ano}");
        }
    }
    // criando um menu para o cadastro de livros

    // criando a função para procurar livros pelo titulo
    static void BuscaTitulo(List<Livros> listadeLivros, string nomeBusca)
    {
        for (int i = 0; i < listadeLivros.Count; i++)
        {
            if (listadeLivros[i].titulo.Equals(nomeBusca))
            {
                // mostrando os dados do livro que o usúario escolheu
                Console.WriteLine($"*** Livro {i + 1} ***");
                Console.WriteLine($"Titulo: {listadeLivros[i].titulo}");
                Console.WriteLine($"Autor: {listadeLivros[i].autor}");
                Console.WriteLine($"Ano: {listadeLivros[i].ano}");
                Console.WriteLine("------------------------------------");
            }
        }
    }
    // criando funções de busca menor e busca maior
    static void BuscaAnoMenor(List<Livros> listadeLivros,int anoNovo)
    {
        for (int i = 0; i < listadeLivros.Count; i++)
        {
            if (listadeLivros[i].ano < anoNovo)
            {
                // mostrando os dados dos livros mais novos
                Console.WriteLine($"*** Livro {i + 1} ***");
                Console.WriteLine($"Titulo: {listadeLivros[i].titulo}");
                Console.WriteLine($"Autor: {listadeLivros[i].autor}");
                Console.WriteLine($"Ano: {listadeLivros[i].ano}");
                Console.WriteLine("------------------------------------");
            }
        }
    }
    static void BuscaAnoMaior(List<Livros> listadeLivros,int anoNovo)
    {
        for (int i = 0; i < listadeLivros.Count; i++)
        {
            if (listadeLivros[i].ano > anoNovo)
            {
                // mostrando os dados dos livros mais novos
                Console.WriteLine($"*** Livro {i + 1} ***");
                Console.WriteLine($"Titulo: {listadeLivros[i].titulo}");
                Console.WriteLine($"Autor: {listadeLivros[i].autor}");
                Console.WriteLine($"Ano: {listadeLivros[i].ano}");
                Console.WriteLine("------------------------------------");
            }
        }
    }
        static int Menu()
        {
            Console.WriteLine("*** Sistema de Cadastro de livros ***");
            Console.WriteLine("1- Adicionar novo livro");
            Console.WriteLine("2- Mostrar");
            Console.WriteLine("3- Procurar por título");
            Console.WriteLine("4- Procurar por livros mais novos");
            Console.WriteLine("5- Procurar por livros mais antigos");
            Console.WriteLine("0- Sair");

            int opcao = int.Parse(Console.ReadLine());
            return opcao;
        }
        static void Main()
        {
            // chamando as funções e o menu de acordo com o pedido do cliente
            int op;
            string tituloBusca;
            int anoBusca;
            int anoBusca2;

            // criando o vetor que salva os livros
            List<Livros> listaDeLivros = new List<Livros>();

            // criando o switch case
            do
            {
                op = Menu();
                switch (op)
                {
                    case 1:
                        AddLivros(listaDeLivros);
                      break;

                    case 2:
                        MostraLivros(listaDeLivros);
                      break;

                    case 3:
                        Console.WriteLine("Digite o titulo que deseja buscar: ");
                        tituloBusca = Console.ReadLine();
                        BuscaTitulo(listaDeLivros, tituloBusca);
                      break;

                    case 4:
                        Console.WriteLine("Digite um ano:");
                        anoBusca = int.Parse(Console.ReadLine());
                        BuscaAnoMenor(listaDeLivros,anoBusca);
                      break;

                    case 5:
                        Console.WriteLine("Digite um ano:");
                        anoBusca2 = int.Parse(Console.ReadLine());
                        BuscaAnoMaior(listaDeLivros,anoBusca2);
                      break;

                    case 0:
                        Console.WriteLine("Saindo...");
                      break;
                } // fim do switch
                Console.ReadKey(); // pausa
                Console.Clear(); // limpa a tela
            } while (op != 0); // fim do while
        }
    }

