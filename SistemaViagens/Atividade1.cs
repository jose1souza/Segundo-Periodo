using System;

class TipoViagem
{
    public string modeloVeiculo;
    public string placaVeiculo;
    public string destino;
    public double kmRodados;
    public double consumoMedio;
}
    public class Atividade1
    {
        static void addViagem(List<TipoViagem> listaDeViagens)
        {
            TipoViagem novaViagem = new TipoViagem();
            Console.WriteLine("*** Dados para Viagem ***");
            Console.Write("Modelo do Veículo: ");
            novaViagem.modeloVeiculo = Console.ReadLine();
            Console.Write("Placa do Veículo: ");
            novaViagem.placaVeiculo = Console.ReadLine();
            Console.Write("Destino: ");
            novaViagem.destino = Console.ReadLine();
            Console.Write("Quilômetros Rodados: ");
            novaViagem.kmRodados = double.Parse(Console.ReadLine());
            Console.Write("Consumo Médio (km/L): ");
            novaViagem.consumoMedio = double.Parse(Console.ReadLine());
            listaDeViagens.Add(novaViagem);
            Console.WriteLine("Viagem cadastrada com sucesso!");
        }

    static void mostraViagens(List<TipoViagem> listaDeViagens)
    {
        for (int i = 0; i < listaDeViagens.Count; i++)
        {
            Console.WriteLine($"*** Viagem{i + 1} ***:");
            Console.WriteLine($"Modelo:{listaDeViagens[i].modeloVeiculo}");
            Console.WriteLine($"Placa:{listaDeViagens[i].placaVeiculo}");
            Console.WriteLine($"Destino:{listaDeViagens[i].destino}");
            Console.WriteLine($"Km Rodados:{listaDeViagens[i].kmRodados}");
            Console.WriteLine($"Consumo médio:{listaDeViagens[i].consumoMedio}");
            Console.WriteLine("------------------------------------");
        }
    }

    static void buscaViagem(List<TipoViagem> listaDeViagens,string placa)
    {
        for(int i = 0;i < listaDeViagens.Count; i++)
        {
            if (listaDeViagens[i].placaVeiculo.Equals(placa))
            {
                Console.WriteLine($"*** Viagem{i + 1} ***:");
                Console.WriteLine($"Modelo:{listaDeViagens[i].modeloVeiculo}");
                Console.WriteLine($"Placa:{listaDeViagens[i].placaVeiculo}");
                Console.WriteLine($"Destino:{listaDeViagens[i].destino}");
                Console.WriteLine($"Km Rodados:{listaDeViagens[i].kmRodados}");
                Console.WriteLine($"Consumo médio:{listaDeViagens[i].consumoMedio}");
                Console.WriteLine("------------------------------------");
            }
        }
    }   
    static void buscaConsumo(List<TipoViagem> listaDeViagens,double consumo)
    {
        for(int i = 0;i < listaDeViagens.Count; i++)
        {
            if (listaDeViagens[i].kmRodados / listaDeViagens[i].consumoMedio > consumo)
            {
                Console.WriteLine($"*** Viagem{i + 1} ***:");
                Console.WriteLine($"Modelo:{listaDeViagens[i].modeloVeiculo}");
                Console.WriteLine($"Placa:{listaDeViagens[i].placaVeiculo}");
                Console.WriteLine($"Destino:{listaDeViagens[i].destino}");
                Console.WriteLine($"Km Rodados:{listaDeViagens[i].kmRodados}");
                Console.WriteLine($"Consumo médio:{listaDeViagens[i].consumoMedio}");
                Console.WriteLine("------------------------------------");
            }
        }
    }
    static void relatorio(List<TipoViagem> listaDeViagem,double custoLitro)
    {
        double consumoTotal;
        double gastoTotal;
        double gastoViagem = 0;
        for (int i = 0;i < listaDeViagem.Count; i++) 
        {
            consumoTotal = listaDeViagem[i].kmRodados / listaDeViagem[i].consumoMedio;
            gastoTotal = consumoTotal * custoLitro;
            gastoViagem += gastoTotal;
            Console.WriteLine($"Consumo Total da viagem: {consumoTotal} litros");
            Console.WriteLine($"Gasto total: {gastoTotal} R$");
        }Console.WriteLine($"Gasto das Viagens: {gastoViagem}");
    }

            static void salvarDados(List<TipoViagem> listaDeViagens, string nomeArquivo)
            {
                StreamWriter writer = new StreamWriter(nomeArquivo);

                foreach (TipoViagem viagem in listaDeViagens)
                {
                    writer.WriteLine($"{viagem.modeloVeiculo},{viagem.placaVeiculo},{viagem.kmRodados},{viagem.consumoMedio},{viagem.destino}");
                }

                Console.WriteLine("Dados salvos com sucesso!");
                writer.Dispose();
            }

            static void carregarDados(List<TipoViagem> listaDeViagens, string nomeArquivo)
            {
                if (File.Exists(nomeArquivo))
                {
                    string[] linhas = File.ReadAllLines(nomeArquivo);
                    foreach (string linha in linhas)
                    {
                        string[] campos = linha.Split(',');
                        TipoViagem viagem = new TipoViagem();
                        viagem.modeloVeiculo = campos[0];
                        viagem.placaVeiculo = campos[1];
                        viagem.kmRodados = double.Parse(campos[2]);
                        viagem.consumoMedio = double.Parse(campos[3]);
                        viagem.destino = campos[4];
                        listaDeViagens.Add(viagem);
                    }
                    Console.WriteLine("Dados carregados com sucesso!");
                }
                else
                {
                    Console.WriteLine("Arquivo não encontrado :(");
                }
            }

            static int menu()
            {
                Console.WriteLine("*** Sistema de Controle de Viagens ***");
                Console.WriteLine("1 - Inserir Viagem");
                Console.WriteLine("2 - Mostrar Viagens");
                Console.WriteLine("3- Buscar por placa");
                Console.WriteLine("4- Salvar em um Arquivo");
                Console.WriteLine("5- Carregar Arquivo");
                Console.WriteLine("6- Busca Consumo");
                Console.WriteLine("7- Exibir Relatório");
                Console.WriteLine("0 - Sair");
                int op = int.Parse(Console.ReadLine());
                return op;
            }

            static void Main()
            {
                List<TipoViagem> listaDeViagens = new List<TipoViagem>();
                int op;
                carregarDados(listaDeViagens, "viagens.txt");
                string nomeArquivo = "viagens.txt";
                string placa;
                double consumo;
                double custo;
        do
                {
                    op = menu();
                    switch (op)
                    {
                        case 1:
                            addViagem(listaDeViagens);
                            break;
                        case 2:
                            mostraViagens(listaDeViagens);
                            break;
                         case 3:
                            Console.WriteLine("Digite a placa para a procura: ");
                            placa = Console.ReadLine();
                            buscaViagem(listaDeViagens, placa);
                             break;
                        case 4:
                            salvarDados(listaDeViagens,nomeArquivo);
                             break; 
                         case 5:
                            carregarDados(listaDeViagens,nomeArquivo);
                           break;
                         case 6:
                            Console.WriteLine("Digite um valor para o consumo médio de combústivél(em litros)");
                            consumo = double.Parse(Console.ReadLine());
                             buscaConsumo(listaDeViagens, consumo);
                            break;
                        case 7:
                            Console.WriteLine("Digite o preço do litro");
                            custo = double.Parse(Console.ReadLine());
                            relatorio(listaDeViagens, custo);
                             break;
                        case 0:
                            Console.WriteLine("Saindo...");
                            salvarDados(listaDeViagens, "viagens.txt");
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                } while (op != 0);
            }
        }
