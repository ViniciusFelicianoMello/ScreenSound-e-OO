using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarBandas : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Registro de Bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!"); Console.WriteLine("\nAperte uma tecla para voltar ao menu principal!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
