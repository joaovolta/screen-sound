//Screen Sound

//List<string> lstBandas = new List<string>(); // Listas sao parecidas com arrays mas sem um tamanho pre definido
Dictionary<string, List<int>> dicBandas = new Dictionary<string, List<int>>();

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
            avaliarBanda();
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
    exibeTituloDaOpcao("Registro de bandas");

    Console.Write("Digite o nome da banda que voce deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    dicBandas.Add(nomeBanda, new List<int>()); // Adiciona o nomeBanda no dicionario dicBandas (key, value)
    Thread.Sleep(2000); // Faz com que o programa fique em modo de espera por 2000 mili segundos
    Console.Clear();
    exibirOpcoesDoMenu();
}

void exibeBandasRegistradas()
{
    Console.Clear();
    // Verifica se a lista esta vazia
    if (dicBandas.Count == 0) {
        Console.WriteLine("\nNenhuma banda foi registrada no momento!");
        Thread.Sleep(2000);
        Console.Clear();
        exibirOpcoesDoMenu();
    }

    exibeTituloDaOpcao("Exibindo bandas registradas");

    // Lista todas as bandas que foram registradas
    //for (int i = 0; i < lstBandas.Count; i++)
    //Console.WriteLine($"Banda: {lstBandas[i]}");

    foreach (string banda in dicBandas.Keys)
        Console.WriteLine("Banda: " + banda);

    Console.WriteLine("\nAperte uma tecla qualquer para retornar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    exibirOpcoesDoMenu();
}

void exibeTituloDaOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length; // Recebe o tamanho em numero da string titulo
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*'); // Multiplica o caracter '*' dependendo da quantidade de letras

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void avaliarBanda()
{
    Console.Clear();
    // Exibe o titulo da opcao
    exibeTituloDaOpcao("Avaliar bandas registradas");
    
    // Pergunta o nome da banda que ele deseja avaliar
    Console.Write("Digite o nome da banda que voce deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;

    // Verifica se a banda esta no nosso dicionario
    if(!dicBandas.ContainsKey(nomeBanda))
    {
        Console.WriteLine($"\nA banda {nomeBanda} nao foi registrada na nossa aplicacao!");
        Thread.Sleep(2000);
        Console.Clear();
        exibirOpcoesDoMenu();
    }

    // Recebemos a nota de avaliacao 
    Console.Write($"\nDigite a nota que voce quer atribuir para a banda {nomeBanda}: ");
    int nota = int.Parse(Console.ReadLine()!);
    dicBandas[nomeBanda].Add(nota); // Atribuimos a nota na lista de inteiros 
    Console.WriteLine($"A nota {nota} foi atribuida com sucesso para a banda {nomeBanda}!");
    Thread.Sleep(2000);
    Console.Clear();
    exibirOpcoesDoMenu();
}

exibirOpcoesDoMenu();