using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Exibir Detalhes da Banda");
            Console.Write("Qual banda você deseja ver a média das notas? :");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine($"\nA media das notas da banda {nomeDaBanda} é {banda.Media}.");
                Console.WriteLine("\ndiscografica");
                /*função de mostrar albuns da banda */
                foreach(Album album in banda.Albuns)
                {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
                }
                Console.WriteLine("\nAperte uma tecla para voltar ao menu principal!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi registrada!");
                Console.WriteLine("\nAperte uma tecla para voltar ao menu principal!");
                Console.ReadKey();
                Console.Clear();
            }
    }
}