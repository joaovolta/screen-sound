//Screen Sound

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
            break;
        case 2:
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

exibeMensagemDeBoasVindas();
exibirOpcoesDoMenu();
