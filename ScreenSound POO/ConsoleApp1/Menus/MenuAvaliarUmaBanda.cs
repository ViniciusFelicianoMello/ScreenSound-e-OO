using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarUmaBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        // Digitar a banda que deseja avaliar
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        // Se a banda existir no dicionario >> atribuir uma nota, Se nao existir voltar ao menu principal
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Qual nota a banda {nomeDaBanda} merece? : ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda} com sucesso!");
            Console.WriteLine("\nAperte uma tecla para voltar ao menu principal!");
            Console.ReadKey();
            Console.Clear();        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi registrada!");
            Console.WriteLine("\nAperte uma tecla para voltar ao menu principal!");
            Console.ReadKey();
            Console.Clear();            }
    }
}
