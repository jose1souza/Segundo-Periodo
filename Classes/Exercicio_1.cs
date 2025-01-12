using System;
using System.IO;
class TipoBanda
{
    //criando uma classe TipoBanda
    public string nome;
    public string genero;
    public int integrantes;
    public int ranking;
}

public class Exercicio_1
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
            if (listadeBandas[i].ranking == rankingbusca)
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
    }static void buscaNumero(List<TipoBanda> listadeBandas, int numero) 
    {
        for (int i = 0; i < listadeBandas.Count; i++)
        {
            if (listadeBandas[i].integrantes == numero)
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
    static void excluirBanda(List<TipoBanda> listadeBandas, int numExcluir)
    { 
        // verificando o índice para que não ocorra erros
        if(numExcluir >= 0 && numExcluir < listadeBandas.Count)
        {
            // excluindo a Banda conforme o índice desejado
            listadeBandas.RemoveAt(numExcluir);
            Console.WriteLine("Banda excluida com sucesso!");
        }
        else
        {
            // índice incorreto
            Console.WriteLine("Você inseriu um índice inválido!");
        }
    }
    static void alterarBanda(List<TipoBanda> listadeBandas, int numAlterar)
    {
        // verificando o índice para alterar
        if(numAlterar >= 0 && numAlterar < listadeBandas.Count)
        {
            // adicionando os novos dados
            Console.WriteLine("Digite o novo nome para a banda: ");
            listadeBandas[numAlterar].nome = Console.ReadLine();
            Console.WriteLine("Digite o novo gênero para a sua banda");
            listadeBandas[numAlterar].genero = Console.ReadLine();
            Console.WriteLine("Quantos integrante tem na banda alterada: ");
            listadeBandas[numAlterar].integrantes = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o ranking da banda alterada: ");
            listadeBandas[numAlterar].ranking = int.Parse(Console.ReadLine());

            // feedback para o usúario
            Console.WriteLine("Banda alterada com sucesso!");
        }
        else
        {
            Console.WriteLine("Você inseriu um índice inválido!");
        }
    }
    // função para salvar dados
    static void salvaDados(List<TipoBanda> listadeBandas, string caminhoDoArquivo)
    {
        using (StreamWriter sw = new StreamWriter(caminhoDoArquivo))
        {
            foreach (TipoBanda banda in listadeBandas)
            {
                sw.WriteLine($"{banda.nome} | {banda.genero} | {banda.integrantes} | {banda.ranking}");
            }
        }
        Console.WriteLine("Dados salvos com sucesso!");
    }
    // função para carregar dados
    static void carregaDados(List<TipoBanda> listadeBandas, string caminhoDoArquivo) 
    {
        if (File.Exists(caminhoDoArquivo)) 
        {
            using (StreamReader sr = new StreamReader(caminhoDoArquivo)) 
            {
                string linhas;
                while((linhas = sr.ReadLine()) != null)
                {
                    string[] dados = linhas.Split('|');
                    TipoBanda banda = new TipoBanda
                    {
                        nome = dados[0],
                        genero = dados[1],
                        integrantes = int.Parse(dados[2]),
                        ranking = int.Parse(dados[3])
                    };
                    listadeBandas.Add(banda);
                }
            }
            Console.WriteLine("Os dados foram carregados com sucesso!!");
        }
        else
        {
            Console.WriteLine("O arquivo não foi encontrado!!");
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
        Console.WriteLine("7- Excluir uma banda");
        Console.WriteLine("8- Alterar uma banda");
        Console.WriteLine("9- Salvar os dados");
        Console.WriteLine("10- Carregar os dados");
        Console.WriteLine("0- Sair");

        int op = int.Parse(Console.ReadLine());
        return op;
    }
    static void Main()
    {
        // vetor que salva tipo de dados do tipo banda
        List<TipoBanda> listadeBandas = new List<TipoBanda>();

        // carrega os dados
        string caminhoDoArquivo = "bandas.txt";

        // chamando as funções e o menu de acordo com o pedido do cliente
        int opcao;
        string nomeBanda;
        string Genero;
        int numIntegrantes;
        int ranking;
        int numRemove;
        int numAdd;

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
                    numIntegrantes = int.Parse(Console.ReadLine());
                    buscaNumero(listadeBandas, numIntegrantes);
                    break;
                case 6:
                    Console.WriteLine("Ranking que você deseja buscar: ");
                    ranking = int.Parse(Console.ReadLine());
                    buscaRanking(listadeBandas, ranking);
                    break;
                case 7:
                    Console.WriteLine("Digite o índice da banda que você deseja excluir: ");
                    numRemove = int.Parse(Console.ReadLine());
                    excluirBanda(listadeBandas, numRemove);
                    break;
                case 8:
                    Console.WriteLine("Digite o índice da banda que você deseja alterar: ");
                    numAdd = int.Parse(Console.ReadLine());
                    alterarBanda(listadeBandas,numAdd);
                    break;
                case 9:
                    salvaDados(listadeBandas,caminhoDoArquivo);
                    break;
                case 10:
                    carregaDados(listadeBandas, caminhoDoArquivo);
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

