using System.Text.Json;
namespace ScreenSound_API.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas {  get; }

    public MusicasPreferidas(string nome) 
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as musicas favoritas de {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string Json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas,
        });
        string NomeDoArquivo = $"musicas favortias - {Nome}.json";

        File.WriteAllText(NomeDoArquivo, Json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(NomeDoArquivo)}");
        Console.WriteLine();
    }

    public void GerarDocumentoTXTComAsMusicasFavoritas()
    {
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
        using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
        {
            arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                arquivo.WriteLine($"- {musica.Nome}");
            }
        }
        Console.WriteLine($"txt gerado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
        Console.WriteLine();
    }
}
