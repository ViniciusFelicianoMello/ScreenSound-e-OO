using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarBandas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas!");
        // for (int i = 0; i < ListaDasBandas.Count; i++)
        // {
        //     Console.WriteLine($"Banda: {ListaDasBandas[i]}");
        // }

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Console.WriteLine("\nAperte uma tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
    }
}
