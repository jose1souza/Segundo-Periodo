using System;
 class Eletrodomesticos
{
    public string nome;
    public double potencia;
    public double tempoMedio;

}
public class Exercicio_3
{
    
    // funcao adiciona eletrodomesticos
    static void AddEle(List<Eletrodomesticos> listaDeEle)
    {
        //função que adiciona os atributos da classe

        //inicio uma variavél
        Eletrodomesticos novosEle = new Eletrodomesticos();

        // preenchendo a lista
        Console.WriteLine("*** Dados para os eletrodomésticos ***");
        Console.Write("Nome: ");
        novosEle.nome = Console.ReadLine();

        Console.Write("Potencia (Em kW): ");
        novosEle.potencia = double.Parse(Console.ReadLine());

        Console.Write("Tempo médio por dia(Em horas): ");
        novosEle.tempoMedio = double.Parse(Console.ReadLine());

        // adicionar os dados na lista 
        listaDeEle.Add(novosEle);
        Console.WriteLine("Dados adicionados com sucesso!!");
    }
    // funcao mostra eletrodomésticos
    static void MostraEle(List<Eletrodomesticos> listaDeEle)
    {
        double consumoDia;
        Console.WriteLine("*** Eletrodomésticos Cadastrados ***");

        for (int i = 0; i < listaDeEle.Count; i++)
        {
            consumoDia = listaDeEle[i].potencia * listaDeEle[i].tempoMedio;
            // mostrando os dados de cada Eletrodoméstico
            Console.WriteLine($"*** Eletrodoméstico {i + 1} ***");
            Console.WriteLine($"Consumo por dia:{consumoDia}");
            Console.WriteLine($"Nome: {listaDeEle[i].nome}");
            Console.WriteLine($"Potencia: {listaDeEle[i].potencia} kW");
            Console.WriteLine($"Tempo médio por dia: {listaDeEle[i].tempoMedio} horas");
            Console.WriteLine("------------------------------------");
        }

    }
    static void SalvaDados(List<Eletrodomesticos> listaDeEle, string caminhoDoArquivo)
    {
        using (StreamWriter sw = new StreamWriter(caminhoDoArquivo))
        {
            foreach (Eletrodomesticos eletrodomesticos in listaDeEle)
            {
                sw.WriteLine($"{eletrodomesticos.nome} | {eletrodomesticos.potencia} | {eletrodomesticos.tempoMedio}");
            }
        }
        Console.WriteLine("Dados salvos com sucesso!");
    }
    static void BuscaNome(List<Eletrodomesticos> listaDeEle, string nomeBusca)
    {
        for (int i = 0; i < listaDeEle.Count; i++)
        {
            if (listaDeEle[i].nome.Equals(nomeBusca))
            {
                // mostrando os dados do Eletrodoméstico que o usúario escolheu
                Console.WriteLine($"*** Eletrodoméstico {i + 1} ***");
                Console.WriteLine($"Nome: {listaDeEle[i].nome}");
                Console.WriteLine($"Potencia: {listaDeEle[i].potencia} kW");
                Console.WriteLine($"Tempo médio por dia: {listaDeEle[i].tempoMedio} horas");
                Console.WriteLine("------------------------------------");
            }
        }
    }
    static void BuscaMaiorConsumo(List<Eletrodomesticos> listaDeEle, double consumo)
    {
        double MaiorConsumo;
        for (int i = 0; i < listaDeEle.Count; i++)
        {
            MaiorConsumo = listaDeEle[i].potencia * listaDeEle[i].tempoMedio;
            if(MaiorConsumo > consumo)
            {
                // mostrando os dados do Eletrodoméstico com consumo maior
                Console.WriteLine($"*** Eletrodoméstico {i + 1} ***");
                Console.WriteLine($"Consumo: {MaiorConsumo} kWh");
                Console.WriteLine($"Nome: {listaDeEle[i].nome}");
                Console.WriteLine($"Potencia: {listaDeEle[i].potencia} kW");
                Console.WriteLine($"Tempo médio por dia: {listaDeEle[i].tempoMedio} horas");
                Console.WriteLine("------------------------------------");
            }
        }
    }
    static void carregaDados(List<Eletrodomesticos> listaDeEle, string caminhoDoArquivo)
    {
        if (File.Exists(caminhoDoArquivo))
        {
            using (StreamReader sr = new StreamReader(caminhoDoArquivo))
            {
                string linhas;
                while ((linhas = sr.ReadLine()) != null)
                {
                    string[] dados = linhas.Split('|');
                    Eletrodomesticos eletrodomesticos = new Eletrodomesticos
                    {
                        nome = dados[0],
                        potencia = double.Parse(dados[1]),
                        tempoMedio = double.Parse(dados[2]),
                    };
                    listaDeEle.Add(eletrodomesticos);
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
        Console.WriteLine("*** Sistema de Cadastro de Eletrodomésticos ***");
        Console.WriteLine("1- Inserir");
        Console.WriteLine("2- Mostrar");
        Console.WriteLine("3- Salvar");
        Console.WriteLine("4- Buscar por nome");
        Console.WriteLine("5- Buscar por maior gasto");
        Console.WriteLine("6- Carregar os dados");
        Console.WriteLine("7- Calcular os gastos");
        Console.WriteLine("0- Sair");

        int op = int.Parse(Console.ReadLine());
        return op;
    }
    static void CalculaConsumo(List<Eletrodomesticos> listaDeEle,double tarifa)
    {
        double consumoMensalTotal = 0;
        double consumoDiarioTotal = 0;
        for (int i = 0; i < listaDeEle.Count; i++)
        {
            double consumoDiario = listaDeEle[i].potencia * listaDeEle[i].tempoMedio;
            double consumoMensal = (listaDeEle[i].potencia * listaDeEle[i].tempoMedio) * 30;
            consumoMensalTotal += consumoMensal;
            consumoDiarioTotal += consumoDiario;
            // mostrando os dados dos Eletrodomésticos
            Console.WriteLine($"*** Eletrodoméstico {i + 1} ***");
            Console.WriteLine($"Consumo Diário: {consumoDiario} kWh");
            Console.WriteLine($"Consumo Mensal: {consumoMensal} kWh");
            Console.WriteLine($"Nome: {listaDeEle[i].nome}");
            Console.WriteLine($"Potencia: {listaDeEle[i].potencia} kW");
            Console.WriteLine($"Tempo médio por dia: {listaDeEle[i].tempoMedio} horas");
            Console.WriteLine("------------------------------------");
        }
        Console.WriteLine($"Consumo Diário Total da casa: {consumoDiarioTotal} kWh");
        Console.WriteLine($"Consumo Mensal Total da casa: {consumoMensalTotal} kWh");

        double custoDiario = consumoDiarioTotal * tarifa;
        double custoMensal = consumoMensalTotal * tarifa;

        Console.WriteLine($"Custo diário total: R$ {custoDiario}");
        Console.WriteLine($"Custo mensal total: R$ {custoMensal}");
    }
    static void Main()
    {
        // vetor que salva tipo de dados do tipo eletrodoméstico
        List<Eletrodomesticos> listaDeEle = new List<Eletrodomesticos>();

        // carrega os dados
        string caminhoDoArquivo = "eletrodomesticos.txt";
        

        int opcao;
        string nomeEle;
        double consumo;
        double tarifaPaga;

        do
        {
            opcao = menu();
            switch (opcao)
            {
                case 1:
                    AddEle(listaDeEle);
                    SalvaDados(listaDeEle, caminhoDoArquivo);
                    break;
                case 2:
                    MostraEle(listaDeEle);
                        break;
                case 3:
                    SalvaDados(listaDeEle, caminhoDoArquivo);
                        break;
                case 4:
                    Console.WriteLine("Digite o nome para a busca:");
                        nomeEle = Console.ReadLine();
                            BuscaNome(listaDeEle,nomeEle);
                                break;
                case 5:
                    Console.WriteLine("Digite o valor de consumo para buscar os maiores que ele");
                    consumo = double.Parse(Console.ReadLine());
                    BuscaMaiorConsumo(listaDeEle, consumo);
                        break;
                case 6:
                    carregaDados(listaDeEle, caminhoDoArquivo);
                        break;
                case 7:
                    Console.WriteLine("Digite a tarifa de eletricidade (Em R$/kWh):");
                        tarifaPaga = double.Parse(Console.ReadLine());
                            CalculaConsumo(listaDeEle, tarifaPaga);
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

