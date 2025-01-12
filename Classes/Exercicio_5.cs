using System;

class Gado
{
    public int codigo;
    public double leite;
    public double alim;
    public string abate;
}
class Nasc
{
    public int mesNascimento;
    public int anoNascimento;
}
public class Exercicio_5
    {
    static void AddGado(List<Gado> listaDeGado)
    {
        //função que adiciona os atributos da classe

        //inicio uma variavél
        Gado novosGados = new Gado();

        // preenchendo a lista
        Console.WriteLine("*** Dados para o Sistema de Gados ***");
        Console.Write("Código: ");
        novosGados.codigo = int.Parse(Console.ReadLine());

        Console.Write("Leite (Em Litros): ");
        novosGados.leite = double.Parse(Console.ReadLine());

        Console.Write("Alim (Em Quilos): ");
        novosGados.alim = double.Parse(Console.ReadLine());

        novosGados.abate = "N";

        // adicionar os dados na lista 
        listaDeGado.Add(novosGados);
        Console.WriteLine("Dados adicionados com sucesso!!");
    }
    static void AddNasc(List<Nasc> listaDeNasc)
    {
        //função que adiciona os atributos da classe

        //inicio uma variavél
        Nasc novosNasc = new Nasc();

        // preenchendo a lista
        Console.WriteLine("*** Dados para o Nascimento do Gado ***");
        Console.Write("Mês de nascimento (Em número): ");
        novosNasc.mesNascimento = int.Parse(Console.ReadLine());
        
        Console.Write("Ano de nascimento: ");
        novosNasc.anoNascimento = int.Parse(Console.ReadLine());

        // adicionar os dados na lista 
        listaDeNasc.Add(novosNasc);
        Console.WriteLine("Dados adicionados com sucesso!!");
    }
    static void MostraGado(List<Gado> listaDeGado)
    {
        Console.WriteLine("*** Gados Cadastrados ***");

        for (int i = 0; i < listaDeGado.Count; i++)
        {
            // mostrando os dados de cada Gado
            Console.WriteLine($"*** Gado {i + 1} ***");
            Console.WriteLine($"Código: {listaDeGado[i].codigo}");
            Console.WriteLine($"Leite produzido por semana: {listaDeGado[i].leite} L");
            Console.WriteLine($"Alimentos consumido por semana: {listaDeGado[i].alim} Kg");
            Console.WriteLine($"Abate: {listaDeGado[i].abate}");
            Console.WriteLine("------------------------------------");
        }
    }
    static void MostraNasc(List<Nasc> listaDeNasc)
    {
        for (int i = 0; i < listaDeNasc.Count; i++)
        {
            Console.WriteLine($"Mês de Nascimento: {listaDeNasc[i].mesNascimento} ");
            Console.WriteLine($"Ano de Nascimento: {listaDeNasc[i].anoNascimento} ");
            Console.WriteLine("------------------------------------");
        }
    }

    static void MostraAbate(List<Nasc> listaDeNasc, List<Gado> listaDeGado,int mesAtual,int anoAtual)
    {
        int idade;
        for (int i = 0; i < listaDeNasc.Count && i < listaDeGado.Count; i++)
        {
            idade = anoAtual - listaDeNasc[i].anoNascimento;
            if(mesAtual < listaDeNasc[i].mesNascimento)
            {
                idade--;
            }
            if(idade > 5 || (listaDeGado[i].leite < 40))
            {
                listaDeGado[i].abate = "S";
            }
            else
            {
                listaDeGado[i].abate = "N";
            }
        }
    }
    static void LeiteTotal(List<Gado> listaDeGado)
    {
        double LeiteTotal = 0;
        for (int i = 0; i < listaDeGado.Count; i++)
        {
            LeiteTotal += listaDeGado[i].leite; 
        }
        Console.WriteLine($"Leite produzido na fazenda: {LeiteTotal}");
    }
    static void AlimTotal(List<Gado> listaDeGado)
    {
        double AlimTotal = 0;
        for (int i = 0; i < listaDeGado.Count; i++)
        {
            AlimTotal += listaDeGado[i].alim; 
        }
        Console.WriteLine($"Alim consumido na fazenda: {AlimTotal}");
    }
    static void MostraGadoAbate(List<Gado> listaDeGado)
    {
        Console.WriteLine("*** Gados Para o Abate ***");

        for (int i = 0; i < listaDeGado.Count; i++)
        {
            if (listaDeGado[i].abate == "S")
            {
                // mostrando os dados de cada Gado
                Console.WriteLine($"*** Gado {i + 1} ***");
                Console.WriteLine($"Código: {listaDeGado[i].codigo}");
                Console.WriteLine($"Leite produzido por semana: {listaDeGado[i].leite} L");
                Console.WriteLine($"Alimentos consumido por semana: {listaDeGado[i].alim} Kg");
                Console.WriteLine($"Abate: {listaDeGado[i].abate}");
                Console.WriteLine("------------------------------------");
            }
        }
    }
    static void SalvaDados(List<Gado> listaDeGado, string caminhoDoArquivo)
    {
        using (StreamWriter sw = new StreamWriter(caminhoDoArquivo))
        {
            foreach (Gado gados in listaDeGado)
            {
                sw.WriteLine($"{gados.codigo} | {gados.leite} | {gados.alim} | {gados.abate}");
            }
        }
        Console.WriteLine("Dados salvos com sucesso!");
    }
    static void SalvaDados2(List<Nasc> listaDeNasc, string caminhoDoArquivo)
    {
        using (StreamWriter sw = new StreamWriter(caminhoDoArquivo))
        {
            foreach (Nasc nascimento in listaDeNasc)
            {
                sw.WriteLine($"{nascimento.mesNascimento} | {nascimento.anoNascimento}");
            }
        }
        Console.WriteLine("Dados salvos com sucesso!");
    }
    static void carregaDados(List<Gado> listaDeGado ,string caminhoDoArquivo)
    {
        if (File.Exists(caminhoDoArquivo))
        {
            using (StreamReader sr = new StreamReader(caminhoDoArquivo))
            {
                string linhas;
                while ((linhas = sr.ReadLine()) != null)
                {
                    string[] dados = linhas.Split('|');
                    Gado gados = new Gado
                    {
                        codigo = int.Parse(dados[0]),
                        leite = double.Parse(dados[1]),
                        alim = double.Parse(dados[2]),
                        abate = dados[3],
                    };
                    listaDeGado.Add(gados);
                }
            }
            Console.WriteLine("Os dados foram carregados com sucesso!!");
        }
        else
        {
            Console.WriteLine("O arquivo não foi encontrado!!");
        }
    }
    static void carregaDados2(List<Nasc> listaDeNasc, string caminhoDoArquivo)
    {
        if (File.Exists(caminhoDoArquivo))
        {
            using (StreamReader sr = new StreamReader(caminhoDoArquivo))
            {
                string linhas;
                while ((linhas = sr.ReadLine()) != null)
                {
                    string[] dados = linhas.Split('|');
                    Nasc nascimento = new Nasc
                    { 
                        mesNascimento = int.Parse(dados[0]),
                        anoNascimento = int.Parse(dados[1]),
                    };
                    listaDeNasc.Add(nascimento);
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
        Console.WriteLine("*** Sistema de Cadastro de Gado ***");
        Console.WriteLine("1- Inserir");
        Console.WriteLine("2- Mostrar");
        Console.WriteLine("3- Salvar");
        Console.WriteLine("4- Carregar os dados");
        Console.WriteLine("5- Mostrar quantidade total " +
            "de leite produzida na fazenda");
        Console.WriteLine("6- Retornar a quantidade total" +
            " de alimento consumido por semana na fazenda.");
        Console.WriteLine("7- Animais que vão para o abate");
        Console.WriteLine("0- Sair");

        int op = int.Parse(Console.ReadLine());
        return op;
    }
    static void Main()
    {
        // vetor que salva tipo de dados do tipo gado
        List<Gado> listaDeGado = new List<Gado>();
        List<Nasc> listaDeNasc = new List<Nasc>();

        // carrega os dados
        string caminhoDoArquivo = "gados.txt";
        string caminhoDoArquivo2 = "nascimento.txt";

        int opcao;
        int anoAtual;
        int mesAtual;

        do
        {
            opcao = menu();
            switch (opcao)
            {
                case 1:
                    AddGado(listaDeGado);
                    AddNasc(listaDeNasc);
                    break;
                case 2:
                    Console.WriteLine("Digite o mês atual ( Em número)");
                    mesAtual = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o ano atual ( Em número)");
                    anoAtual = int.Parse(Console.ReadLine());
                    MostraAbate(listaDeNasc, listaDeGado, mesAtual, anoAtual);
                    MostraGado(listaDeGado);
                    MostraNasc(listaDeNasc);
                    break;
                case 3:
                    SalvaDados(listaDeGado, caminhoDoArquivo);
                    SalvaDados2(listaDeNasc, caminhoDoArquivo2);
                    break;
                case 4:
                    carregaDados(listaDeGado, caminhoDoArquivo);
                    carregaDados2(listaDeNasc, caminhoDoArquivo2);
                    break;
                case 5:
                    LeiteTotal(listaDeGado);
                    break;
                case 6:
                    AlimTotal(listaDeGado);
                    break;
                case 7:
                    MostraGadoAbate(listaDeGado);
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
