using System;

class TipoBanda
{
    //criando uma classe TipoBanda
    public string nome;
    public string genero;
    public int integrantes;
    public int ranking;
}

public class ExercicioTipoBanda
    {
    
    static void addBanda(List<TipoBanda> listadeBandas)
    {
        //função que adiciona os atributos da classe

        //inicio uma variavél tipo Banda
        TipoBanda novaBanda = new TipoBanda();

        // preenchendo a lista
        Console.WriteLine("*** Dados para Banda ***");
        Console.Write("Nome: ");
        novaBanda.nome = Console.ReadLine();

        Console.Write("Genero: ");
        novaBanda.genero = Console.ReadLine();

        Console.Write("Número de integrantes: ");
        novaBanda.integrantes = int.Parse(Console.ReadLine());

        Console.Write("Ranking da banda: ");
        novaBanda.ranking = int.Parse(Console.ReadLine());

        // adicionar os dados na lista 
        listadeBandas.Add(novaBanda);
        Console.WriteLine("Dados adicionados com sucesso!!");
    }
    static void MostraBandas(List<TipoBanda> listadeBandas)
    {
        Console.WriteLine("*** Bandas Cadastradas ***");

            for(int i = 0; i < listadeBandas.Count; i++)
        {
            // mostrando os dados de cada Banda
            Console.WriteLine($"*** Banda {i+1} ***");
            Console.WriteLine($"Nome: {listadeBandas[i].nome}");
            Console.WriteLine($"Gênero: {listadeBandas[i].genero}");
            Console.WriteLine($"Integrantes: {listadeBandas[i].integrantes}");
            Console.WriteLine($"Ranking: {listadeBandas[i].ranking}");
            Console.WriteLine("------------------------------------");
        }

    }
    static void buscaNome(List<TipoBanda> listadeBandas, string nomeBusca) 
    {
        for (int i = 0; i < listadeBandas.Count; i++)
        {
            if (listadeBandas[i].nome.Equals(nomeBusca))
            {
                // mostrando os dados da Banda que o usúario escolheu
                Console.WriteLine($"*** Banda {i + 1} ***");
                Console.WriteLine($"Nome: {listadeBandas[i].nome}");
                Console.WriteLine($"Gênero: {listadeBandas[i].genero}");
                Console.WriteLine($"Integrantes: {listadeBandas[i].integrantes}");
                Console.WriteLine($"Ranking: {listadeBandas[i].ranking}");
                Console.WriteLine("------------------------------------");
            }
        }
    }static void buscaGenero(List<TipoBanda> listadeBandas, string Genero) 
    {
        for (int i = 0; i < listadeBandas.Count; i++)
        {
            if (listadeBandas[i].genero.Equals(Genero))
            {
                // mostrando os dados da Banda que o usúario escolheu
                Console.WriteLine($"*** Banda {i + 1} ***");
                Console.WriteLine($"Nome: {listadeBandas[i].nome}");
                Console.WriteLine($"Gênero: {listadeBandas[i].genero}");
                Console.WriteLine($"Integrantes: {listadeBandas[i].integrantes}");
                Console.WriteLine($"Ranking: {listadeBandas[i].ranking}");
                Console.WriteLine("------------------------------------");
            }
        }
    }static void buscaRanking(List<TipoBanda> listadeBandas, int rankingbusca) 
    {
        for (int i = 0; i < listadeBandas.Count; i++)
        {
            if (listadeBandas[i].ranking.Equals(rankingbusca))
            {
                // mostrando os dados da Banda que o usúario escolheu
                Console.WriteLine($"*** Banda {i + 1} ***");
                Console.WriteLine($"Nome: {listadeBandas[i].nome}");
                Console.WriteLine($"Gênero: {listadeBandas[i].genero}");
                Console.WriteLine($"Integrantes: {listadeBandas[i].integrantes}");
                Console.WriteLine($"Ranking: {listadeBandas[i].ranking}");
                Console.WriteLine("------------------------------------");
            }
        }
    }static void buscanumero(List<TipoBanda> listadeBandas, int numero) 
    {
        for (int i = 0; i < listadeBandas.Count; i++)
        {
            if (listadeBandas[i].genero.Equals(numero))
            {
                // mostrando os dados da Banda que o usúario escolheu
                Console.WriteLine($"*** Banda {i + 1} ***");
                Console.WriteLine($"Nome: {listadeBandas[i].nome}");
                Console.WriteLine($"Gênero: {listadeBandas[i].genero}");
                Console.WriteLine($"Integrantes: {listadeBandas[i].integrantes}");
                Console.WriteLine($"Ranking: {listadeBandas[i].ranking}");
                Console.WriteLine("------------------------------------");
            }
        }
    }

    static int menu()
    {
        Console.WriteLine("*** Sistema de Cadastro de Bandas ***");
        Console.WriteLine("1- Inserir");
        Console.WriteLine("2- Mostrar");
        Console.WriteLine("3- Buscar nome");
        Console.WriteLine("4- Buscar gênero");
        Console.WriteLine("5- Buscar número de integrantes");
        Console.WriteLine("6- Buscar Ranking");
        Console.WriteLine("0- Sair");

        int op = int.Parse(Console.ReadLine());
        return op;
    }
    static void Main()
    {
        // vetor que salva tipo de dados do tipo banda
        List<TipoBanda> listadeBandas = new List<TipoBanda>();

        // chamando as funções e o menu de acordo com o pedido do cliente
        int opcao;
        string nomeBanda;
        string Genero;
        int numintegrantes;
        int ranking;
        do
        {
            opcao = menu();
            switch (opcao)
            {
                case 1: 
                  addBanda(listadeBandas); 
                    break;
                case 2:
                    MostraBandas(listadeBandas);
                    break;
                case 3:
                    Console.WriteLine("Nome da banda que você deseja buscar: ");
                    nomeBanda = Console.ReadLine();
                    buscaNome(listadeBandas, nomeBanda);
                    break;
                case 4:
                    Console.WriteLine("Genero que você deseja buscar: ");
                    Genero = Console.ReadLine();
                    buscaGenero(listadeBandas, Genero);
                    break;
                case 5:
                    Console.WriteLine("Número de integrantes que você deseja buscar: ");
                    numintegrantes = int.Parse(Console.ReadLine());
                    buscanumero(listadeBandas, numintegrantes);
                    break;
                case 6:
                    Console.WriteLine("Ranking que você deseja buscar: ");
                    ranking = int.Parse(Console.ReadLine());
                    buscaRanking(listadeBandas, ranking);
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

