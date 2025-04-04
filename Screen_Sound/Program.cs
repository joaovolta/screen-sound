//Screen Sound

List<string> lstBandas = new List<string>(); // Listas sao parecidas com arrays mas sem um tamanho pre definido

void exibeMensagemDeBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound!!");
}

void exibirOpcoesDoMenu()
{
    exibeMensagemDeBoasVindas();

    Console.WriteLine("\n1 - Para registrar uma banda");
    Console.WriteLine("2 - Para mostrar todas as bandas");
    Console.WriteLine("3 - Para avaliar uma banda");
    Console.WriteLine("4 - Para exibir a media de uma banda");
    Console.WriteLine("0 - Para sair do programa");

    Console.Write("\nDigite uma das opcoes: ");
    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);

    switch(opcaoNumerica)
    {
        case 1:
            registrarBandas();
            break;
        case 2:
            exibeBandasRegistradas();
            break;
        case 3:
            break;
        case 4:
            break;
        case 0:
            break;
        default:
            break;
    }
}

void registrarBandas()
{
    Console.Clear(); // Limpa o terminal
    Console.WriteLine("******************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("******************\n");

    Console.Write("Digite o nome da banda que voce deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    lstBandas.Add(nomeBanda); // Adiciona o nomeBanda na lista lstBandas
    Thread.Sleep(2000); // Faz com que o programa fique em modo de espera por 2000 mili segundos
    Console.Clear();
    exibirOpcoesDoMenu();
}

void exibeBandasRegistradas()
{
    Console.Clear();
    // Verifica se a lista esta vazia
    if (lstBandas.Count == 0) {
        Console.WriteLine("\nNenhuma banda foi registrada no momento!");
        Thread.Sleep(2000);
        Console.Clear();
        exibirOpcoesDoMenu();
    }

    Console.WriteLine("******************************");
    Console.WriteLine("Exibindo as bandas registradas");
    Console.WriteLine("******************************\n");

    // Lista todas as bandas que foram registradas
    for (int i = 0; i < lstBandas.Count; i++)
        Console.WriteLine($"Banda: {lstBandas[i]}");

    Console.WriteLine("\nAperte uma tecla qualquer para retornar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    exibirOpcoesDoMenu();
}

exibirOpcoesDoMenu();