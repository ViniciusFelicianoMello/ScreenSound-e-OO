using ScreenSound.Menus;
using ScreenSound.Modelos;
using OpenAI_API;

var client = new OpenAIAPI();


Banda Slipknot = new Banda("Slipknot");
Slipknot.AdicionarNota(new Avaliacao(10));
Slipknot.AdicionarNota(new Avaliacao (8));
Slipknot.AdicionarNota(new Avaliacao (6));

Banda SOAD = new Banda("System of a Down");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(Slipknot.Nome, Slipknot);
bandasRegistradas.Add(SOAD.Nome, SOAD);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBandas());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandas());
opcoes.Add(4, new MenuAvaliarUmaBanda());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("\nBem vindo ao Screen Sound");
}

void ExibirMenuOpcoes()
{
    ExibirMensagemDeBoasVindas();
    Console.WriteLine("\nDigite 1 para registrar banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite a sua opção!: ");

    string OpcaoEscolhida = Console.ReadLine()!;
    int OpcaoEscolhidaNumerica = int.Parse(OpcaoEscolhida);
  

    if (opcoes.ContainsKey(OpcaoEscolhidaNumerica))
    {
        Menu MenuExibido = opcoes[OpcaoEscolhidaNumerica];
        MenuExibido.Executar(bandasRegistradas);
        if (OpcaoEscolhidaNumerica > 0) ExibirMenuOpcoes();
    }
    else
    {
        Console.WriteLine("Opção invalida!");
    }
}

    ExibirMenuOpcoes();


    // if (OpcaoEscolhidaNumerica == 1)
    // {
    //     Console.WriteLine("Você digitou a opção " + OpcaoEscolhida);
    // } else if (OpcaoEscolhidaNumerica == 2)
    // {
    //     Console.WriteLine("Você digitou a opção " + OpcaoEscolhida);
    // }



/* switch (OpcaoEscolhidaNumerica)
{
    case 1:
        MenuRegistrarBandas menu1 = new MenuRegistrarBandas();
        menu1.Executar(bandasRegistradas);
        ExibirMenuOpcoes();
        break;
    case 2:
        MenuRegistrarAlbum menu2 = new MenuRegistrarAlbum();
        menu2.Executar(bandasRegistradas);
        ExibirMenuOpcoes();
        break;
    case 3:
        MenuMostrarBandas menu3 = new MenuMostrarBandas();
        menu3.Executar(bandasRegistradas);
        ExibirMenuOpcoes();
        break;
    case 4:
        MenuAvaliarUmaBanda menu4 = new MenuAvaliarUmaBanda();
        menu4.Executar(bandasRegistradas);
        ExibirMenuOpcoes();
        break;
    case 5:
        MenuExibirDetalhes menu5 = new MenuExibirDetalhes();
        menu5.Executar(bandasRegistradas);
        ExibirMenuOpcoes();
        break;
    case -1:
        MenuExibirDetalhes menu11 = new MenuExibirDetalhes();
        menu11.Executar(bandasRegistradas);
        break;
    default:
        Console.WriteLine("Opção invalida!");
        break;
}
} */



