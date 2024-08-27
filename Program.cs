using System.Runtime.InteropServices;

class program
{



    static void Main(string[] args)
    {
        int opcao = -1;
        while (opcao != 0)
        {
            Console.Clear();
            System.Console.WriteLine("=========Menu Cadastro========");
            System.Console.WriteLine("");
            System.Console.WriteLine("Escolha uma das opçoes abaixo:");
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("");
            System.Console.WriteLine("1 --- Cadastrar  novo usuario:");
            System.Console.WriteLine("2 --- Listar usuario cadastrado:");
            System.Console.WriteLine("3 --- Editar cadastro de usuario:");
            System.Console.WriteLine("4 --- Excluir cadastro de usuario:");
            System.Console.WriteLine("");
            System.Console.WriteLine("0 --- Encerrar programa:");
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1: Console.Clear(); Cadastro.AdicionarCadastro(); break;
                case 2: Console.Clear(); Cadastro.ListarCadastro(); break;
                case 3: Console.Clear(); Cadastro.EditarCadastro(); break;
                case 4: Console.Clear(); Cadastro.ExcluirCadastro(); break;
                case 0:
                    Console.Clear(); System.Console.WriteLine("####-PROGRAMA ENCERRADO-####");
                    System.Console.WriteLine("");
                    System.Console.WriteLine(""); break;

            }

        }
    }




}


public class Cadastro
{
    public string Gmail { get; set; }
    public long Senha { get; set; }
    public string Nome { get; set; }

    Cadastro(string gmail, long senha, string nome)
    {

        Gmail = gmail;
        Senha = senha;
        Nome = nome;

    }
    public static List<Cadastro> cadastros = new List<Cadastro>();
    public static void AdicionarCadastro()
    {
        int OpecaoAdicionar = -1;
        while (OpecaoAdicionar != 2)
        {


            Console.Clear();
            System.Console.WriteLine("===============================");
            System.Console.WriteLine("ADICIONANDO CADASTRO.");
            System.Console.WriteLine("===============================");
            System.Console.WriteLine("");
            System.Console.WriteLine("|=========NOME=========|");
            System.Console.WriteLine("");
            System.Console.WriteLine("Digite o nome do usuario:");
            string nome = Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine("|========GMAIL=========|");
            System.Console.WriteLine("");
            System.Console.WriteLine("Digite um Gmail valido:");
            string gmail = Console.ReadLine();
            System.Console.WriteLine("");
            System.Console.WriteLine("|==============================|");
            System.Console.WriteLine("Gmail Cadastro com sucesso!");
            System.Console.WriteLine("|==============================|");
            Thread.Sleep(2000);
            //login senha.
            Console.Clear();
            System.Console.WriteLine("|=========SENHA======|");
            System.Console.WriteLine("");
            System.Console.WriteLine("Crie uma senha:");
            long senha = Convert.ToInt64(Console.ReadLine());
            System.Console.WriteLine("");
            System.Console.WriteLine("=============================");
            System.Console.WriteLine(" Senha cadastrada com sucesso!");
            System.Console.WriteLine("=============================");
            Thread.Sleep(2000);
            Console.Clear();
            System.Console.WriteLine("CADASTRO CONCLUIDO.");

            Cadastro cadastro = new Cadastro(gmail, senha, nome);
            cadastros.Add(cadastro);

            System.Console.WriteLine("");
            System.Console.WriteLine("-----------------------------------------");
            System.Console.WriteLine("Clique qualquer tecla para continuar:");
            Console.ReadKey();
            Console.Clear();
            System.Console.WriteLine("Escolha uma das opções abaixo:");
            System.Console.WriteLine("");
            System.Console.WriteLine("1 -- Adicionar outro cadastro:");
            System.Console.WriteLine("2 -- Voltar ao Menu:");
            System.Console.WriteLine("");
            System.Console.WriteLine("3 -- Encerrar programa:");
            OpecaoAdicionar = Convert.ToInt32(Console.ReadLine());
            if (OpecaoAdicionar == 1)
            {

                Console.Clear();
                System.Console.WriteLine("adicionando outro Cadastro...");
                Thread.Sleep(1500);
            }
            else if (OpecaoAdicionar == 2)
            {

                Console.Clear();
                System.Console.WriteLine("Voltando ao menu...");
                Thread.Sleep(1500);
            }
            else if (OpecaoAdicionar == 0)
            {

                Console.Clear();
                System.Console.WriteLine("----PROGRAMA ENCERRADO-----");
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                Environment.Exit(0);
            }
        }
    }
    public static void ListarCadastro()
    {
        bool lacoRepeticao = true;
        while (lacoRepeticao)
        {


            Console.Clear();
            System.Console.WriteLine("====================");
            System.Console.WriteLine("LISTANDO CADASTRO.");
            System.Console.WriteLine("====================");
            System.Console.WriteLine("");

            foreach (Cadastro cadastro in cadastros)
            {

                System.Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                System.Console.WriteLine($" o nome do usuario é: {cadastro.Nome} |  Gmail cadastrado é:  {cadastro.Gmail} |  A senha cadastrada é: {cadastro.Senha}.");
                System.Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            }
            System.Console.WriteLine("");
            System.Console.WriteLine("*************************************");
            System.Console.WriteLine("TODOS OS CADASTROS FORAM LISTADOS");
            System.Console.WriteLine("*************************************");
            System.Console.WriteLine("");
            System.Console.WriteLine("clique qualque tecla para continuar:");
            Console.ReadKey();

            Console.Clear();
            System.Console.WriteLine("escolha uma das opções abaixo:");
            System.Console.WriteLine("1 --- Voltar ao Menu:");
            System.Console.WriteLine("2 --- Listar novamente:");
            System.Console.WriteLine("");
            System.Console.WriteLine(" 0 --- Encerrar Programa:");
            int opcaoList = Convert.ToInt32(Console.ReadLine());
            if (opcaoList == 1)
            {
                Console.Clear();
                System.Console.WriteLine("voltando ao menu...");
                Thread.Sleep(1500);
                lacoRepeticao = false;
            }
            else if (opcaoList == 2)
            {
                Console.Clear();
                System.Console.WriteLine("Listando novamente...");
                Thread.Sleep(1500);
            }
            else if (opcaoList == 0)
            {

                Console.Clear();
                System.Console.WriteLine("-----PROGRAMA ENCERRADO.-----");
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                Environment.Exit(0);
            }

        }
    }
    public static void EditarCadastro()
    {
        bool repeticaoEditar = true;
        while (repeticaoEditar)
        {


            Console.Clear();
            System.Console.WriteLine("=========Editar cadastro========");
            System.Console.WriteLine("");
            System.Console.WriteLine("insira o  nome do cadastro que deseja editar:");
            string nomeDocaDastro = Console.ReadLine();
            System.Console.WriteLine("------------------------------------------------");

            Cadastro cadastro = cadastros.Find(p => p.Nome.Equals(nomeDocaDastro, StringComparison.OrdinalIgnoreCase));
            if (cadastro != null)
            {

                System.Console.WriteLine($"o nome do cadastro encontrado é : {cadastro.Nome}");
                System.Console.WriteLine("");
                System.Console.WriteLine("----------------------------------------------------");
                System.Console.WriteLine("esse é o cadastro que deseja editar ?");
                System.Console.WriteLine("1 -- não");
                System.Console.WriteLine("2 -- sim");
                int opcaoNomecadastro = Convert.ToInt32(Console.ReadLine());

                if (opcaoNomecadastro == 1)
                {
                    Console.Clear();
                    System.Console.WriteLine("digite o nome do cadastro  novamente...");
                    Thread.Sleep(1500); continue;
                }
                else if (opcaoNomecadastro == 2)
                {
                    Console.Clear();
                    System.Console.WriteLine("-----------------------------------------");
                    System.Console.WriteLine("Insira o novo  nome do Cadastro: ");
                    cadastro.Nome = Console.ReadLine();
                    System.Console.WriteLine("-----------------------------------------");
                    System.Console.WriteLine($"insira o novo Gmail de {cadastro.Nome}: ");
                    cadastro.Gmail = Console.ReadLine();
                    System.Console.WriteLine("-----------------------------------------");
                    System.Console.WriteLine($"Insira a nova senha de {cadastro.Nome}:");
                    cadastro.Senha = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("-----------------------------------------");
                    System.Console.WriteLine("");
                    System.Console.WriteLine("CADASTRO EDITADO COM SUCESSO!");
                    Thread.Sleep(1500);
                }
            }
            else
            {
                Console.Clear();
                System.Console.WriteLine("CADASTRO NÃO ENCONTRADO!");
                System.Console.WriteLine("");
                System.Console.WriteLine("Escolha uma das opções abaixo:");
                System.Console.WriteLine(" 1 -- Editar Novamete:");
                System.Console.WriteLine(" 2 -- Voltar ao menu:");
                System.Console.WriteLine(" 3 -- Encerrar programa:");
                short opcaoCadastroNaoEncontrado = short.Parse(Console.ReadLine());
                if (opcaoCadastroNaoEncontrado == 1)
                {
                    Console.Clear();
                    System.Console.WriteLine("voltando ao metodo editar ...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }
                else if (opcaoCadastroNaoEncontrado == 2)
                {

                    Console.Clear();
                    System.Console.WriteLine("Voltando ao menu...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    repeticaoEditar = false;
                    return;


                }
                else if (opcaoCadastroNaoEncontrado == 3)
                {
                    Console.Clear();
                    System.Console.WriteLine("PROGRAMA ENCERRADO.");
                    System.Console.WriteLine("");
                    System.Console.WriteLine("");
                    Environment.Exit(0);
                }
                else
                {
                    while (opcaoCadastroNaoEncontrado != 1 && opcaoCadastroNaoEncontrado != 2 && opcaoCadastroNaoEncontrado != 3)
                    {
                        System.Console.WriteLine("RESPOSTA INVALIDA!");
                        opcaoCadastroNaoEncontrado = short.Parse(Console.ReadLine());
                        Console.Clear();
                    }


                }

            }
            {


                System.Console.WriteLine("clique qualquer tecla para continuar:");
                Console.ReadKey();
                Console.Clear();
                System.Console.WriteLine("Escolha uma das opções abaixo:");
                System.Console.WriteLine(" 1 -- listar  cadastro:");
                System.Console.WriteLine(" 2 -- Editar novamente outro cadastro:");
                System.Console.WriteLine(" 3 -- Voltar ao menu Principal:");
                System.Console.WriteLine("-----------------------------------------");
                short opcao = short.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        System.Console.WriteLine("Voltando para Listar cadastro...");
                        repeticaoEditar = false;
                        Cadastro.ListarCadastro();
                        break;

                    case 2:
                        Console.Clear();
                        System.Console.WriteLine("Voltando para Editar  cadastro...");
                        repeticaoEditar = false;
                        Cadastro.EditarCadastro();
                        break;
                    case 3:
                        Console.Clear();

                        System.Console.WriteLine("Voltando para Menu de  cadastro...");
                        repeticaoEditar = false;
                        return;
                }
            }

        }

    }
    public static void ExcluirCadastro()
    {

        Console.Clear();
        System.Console.WriteLine("-----EXCLUIR CADASTRO------");
        System.Console.WriteLine("");
        System.Console.WriteLine("insira o nome do cadastro que deseja excluir:");
        string nomeCadastro = Console.ReadLine();

        Cadastro cadastro = cadastros.Find(p => p.Nome.Equals(nomeCadastro, StringComparison.OrdinalIgnoreCase));
        if (cadastro != null)
        {
            Console.Clear();
            System.Console.WriteLine("Cadastro encontrado!");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine($"O cadastro que você deseja excluir é {cadastro.Nome}?");
            System.Console.WriteLine("");
            System.Console.WriteLine(" 1 -- sim");
            System.Console.WriteLine(" 2 -- não");
            int opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1)
            {
                Console.Clear();
                cadastros.Remove(cadastro);
                System.Console.WriteLine("CADASTRO REMOVIDO.");
                System.Console.WriteLine("-------------------");
                System.Console.WriteLine("precione qualquer tecla para continuar:");
                Console.ReadKey();

            }
            else if (opcao == 2)
            {
                System.Console.WriteLine("Voltando para o Menu...");
                Thread.Sleep(1500);
                Console.Clear();
            }
            else if (opcao != 1 && opcao != 2)
            {

                System.Console.WriteLine("OPÇÃO INVALIDA");
                System.Console.WriteLine("");
                opcao = Convert.ToInt32(Console.ReadLine());
            }


        }
        else
        {
            Console.Clear();
            System.Console.WriteLine("Cadastro não encontrado!");
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("escolha uma das opções abaixo");
            System.Console.WriteLine(" 1 -- Voltar ao Menu:");
            System.Console.WriteLine(" 2 -- excluir novamente  Cadastro");
            int opcao1 = int.Parse(Console.ReadLine());
            switch (opcao1)
            {

                case 1:
                    Console.Clear();
                    System.Console.WriteLine("Voltando ao Menu...");
                    Thread.Sleep(1500);
                    break;
                case 2: ExcluirCadastro(); break;
            }

        }




    }





};






















