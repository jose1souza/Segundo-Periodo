using System;

class Jogos
{
    public string titulo;
    public string console;
    public int ano;
    public int ranking;
}
class Emprestimo
{
    public int data;
    public string nomePessoa;
    public string emprestado;
}
    public class Exercicio_4
    {
    static void AddJogos(List<Jogos> listaDeJogos)
    {
        //função que adiciona os atributos da classe

        //inicio uma variavél
        Jogos novosJogos = new Jogos();

        // preenchendo a lista
        Console.WriteLine("*** Dados para o Sistema de Jogos ***");
        Console.Write("Título: ");

        // conferindo a quantidade de caracteres
        bool Confer = true;
        novosJogos.titulo = Console.ReadLine();

        if (novosJogos.titulo.Length > 30)
        {
            Confer = false;
            Console.WriteLine("O título possui mais que 30 caracteres");
        }
        Console.Write("Console: ");
        novosJogos.console = Console.ReadLine();

        if (novosJogos.console.Length > 15)
        {
            Confer = false;
            Console.WriteLine("O console possui mais que 15 caracteres");
        }

        Console.Write("Ano: ");
        novosJogos.ano = int.Parse(Console.ReadLine());

        Console.Write("Ranking: ");
        novosJogos.ranking = int.Parse(Console.ReadLine());

        // adicionar os dados na lista 
        listaDeJogos.Add(novosJogos);
        Console.WriteLine("Dados adicionados com sucesso!!");
    }
    static void ProcuraTitulo(List<Jogos> listaDeJogos, string busca)
    {
        for (int i = 0; i < listaDeJogos.Count; i++) 
        {
            if (listaDeJogos[i].titulo == busca)
            {
                Console.WriteLine($"Titulo: {listaDeJogos[i].titulo}");
                Console.WriteLine($"Console: {listaDeJogos[i].console}");
                Console.WriteLine($"Ano:{listaDeJogos[i].ano}");
                Console.WriteLine($"Ranking: {listaDeJogos[i].ranking}");
            }
        }
    }
    static void AddEmprestimo(List<Emprestimo> listaDeEmpre,List<Jogos> listaDeJogos)
    {
        //função que adiciona os atributos da classe

        //inicio uma variavél
        Emprestimo novosEmprestimo = new Emprestimo();
        for (int i = 0; i < listaDeJogos.Count; i++)
        {
            // preenchendo a lista
            Console.WriteLine("*** Dados para o Empréstimo do jogo ***");
            Console.WriteLine("Digite o titulo do jogo que deseja pegar:");
            string nomeJogo = Console.ReadLine();
            if (nomeJogo == listaDeJogos[i].titulo)
            {
                Console.Write("Data (dia/mês/ano): ");
                novosEmprestimo.data = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                novosEmprestimo.nomePessoa = Console.ReadLine();

                novosEmprestimo.emprestado = "S";

                // adicionar os dados na lista 
                listaDeEmpre.Add(novosEmprestimo);
                Console.WriteLine("Empréstimo feito com sucesso!!");
            }
            else
            {
                Console.WriteLine("Não existe jogos com esse titulo");
            }
        }
    }
    static void Devolve(List<Emprestimo> listaDeEmpre,List<Jogos> listaDeJogos)
    {
        //função que adiciona os atributos da classe

        //inicio uma variavél
        Emprestimo novosEmprestimo = new Emprestimo();
        for (int i = 0; i < listaDeJogos.Count; i++)
        {
            // preenchendo a lista
            Console.WriteLine("*** Dados para a Devolução do jogo ***");
            Console.WriteLine("Digite o titulo do jogo que deseja devolver:");
            string nomeJogo = Console.ReadLine();
            if (nomeJogo == listaDeJogos[i].titulo)
            {
                novosEmprestimo.emprestado = "N";
                listaDeEmpre.Add(novosEmprestimo);
                Console.WriteLine("Devolvolução feita com sucesso!!");
            }
            else
            {
                Console.WriteLine("Não existe jogos com esse titulo");
            }
        }
    }
    static void MostraJogos(List<Jogos> listaDeJogos)
    {
        Console.WriteLine("*** Jogos Cadastrados ***");

        for (int i = 0; i < listaDeJogos.Count; i++)
        {
            // mostrando os dados de cada Jogo
            Console.WriteLine($"*** Jogo {i + 1} ***");
            Console.WriteLine($"Titulo: {listaDeJogos[i].titulo}");
            Console.WriteLine($"Console: {listaDeJogos[i].titulo}");
            Console.WriteLine($"Ano: {listaDeJogos[i].ano}");
            Console.WriteLine($"Ranking: {listaDeJogos[i].ranking}");
            Console.WriteLine("------------------------------------");
        }
    }
    static void MostraEmprestimo(List<Emprestimo> listaDeEmpre)
    {
        for (int i = 0; i < listaDeEmpre.Count; i++)
        {
            Console.WriteLine($"Data: {listaDeEmpre[i].data} ");
            Console.WriteLine($"nomePessoa: {listaDeEmpre[i].nomePessoa} ");
            Console.WriteLine($"Emprestado: {listaDeEmpre[i].emprestado} ");
            Console.WriteLine("------------------------------------");
        }
    }
    static void MostraJogosEmprestados(List<Jogos> listaDeJogos,List<Emprestimo>listaDeEmpre)
    {
        Console.WriteLine("*** Jogos Emprestrados ***");

        for (int i = 0; i < listaDeJogos.Count; i++)
        {
            if (listaDeEmpre[i].emprestado == "S")
            {
                // mostrando os dados de cada Jogo
                Console.WriteLine($"*** Jogo {i + 1} ***");
                Console.WriteLine($"Titulo: {listaDeJogos[i].titulo}");
                Console.WriteLine($"Console: {listaDeJogos[i].titulo}");
                Console.WriteLine($"Ano: {listaDeJogos[i].ano}");
                Console.WriteLine($"Ranking: {listaDeJogos[i].ranking}");
                Console.WriteLine("------------------------------------");
            }
        }
    }

    static int menu()
    {
        Console.WriteLine("*** Sistema de Cadastro de Jogos ***");
        Console.WriteLine("1- Inserir");
        Console.WriteLine("2- Mostrar Jogos");
        Console.WriteLine("3- Realizar Empréstimo");
        Console.WriteLine("4- Devolver Jogo");
        Console.WriteLine("5- Mostrar Jogos Emprestados");
        Console.WriteLine("6- Procurar jogo por titulo");
        Console.WriteLine("0- Sair");

        int op = int.Parse(Console.ReadLine());
        return op;
    }
    static void Main()
    {
        // vetor que salva tipo de dados do tipo jogos
        List<Jogos> listaDeJogos = new List<Jogos>();
        List<Emprestimo> listaDeEmprestimo = new List<Emprestimo>();

        int opcao;
        string buscaNome;
        do
        {
            opcao = menu();
            switch (opcao)
            {
                case 1:
                    AddJogos(listaDeJogos);
                    break;
                case 2:
                    MostraJogos(listaDeJogos);
                    break;
                case 3:
                    AddEmprestimo(listaDeEmprestimo,listaDeJogos);
                    break;
                case 4:
                    Devolve(listaDeEmprestimo,listaDeJogos);
                    break;
                case 5:
                    MostraJogosEmprestados(listaDeJogos,listaDeEmprestimo);
                    break;
                case 6:
                    Console.WriteLine("Titulo do jogo para buscar:");
                        buscaNome = Console.ReadLine();
                            ProcuraTitulo(listaDeJogos, buscaNome);
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
            } // fim do switch

            Console.ReadKey(); // pausa
            Console.Clear(); // limpa a tela

        } while (opcao != 0); // fim do while
    }
    }

