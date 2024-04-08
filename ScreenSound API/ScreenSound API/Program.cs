using ScreenSound_API.Modelos;
using System.Text.Json;
using ScreenSound_API.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");   
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "pop");
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //musicas[0].ExibirDetalhesDaMusica();
        //Console.WriteLine(musicas.Count); /*Quantas Musicas tem na API*/

        var MusicasPreferidasVinicius = new MusicasPreferidas("Vinicius");
        MusicasPreferidasVinicius.AdicionarMusicasFavoritas(musicas[0]);
        MusicasPreferidasVinicius.AdicionarMusicasFavoritas(musicas[1]);
        MusicasPreferidasVinicius.AdicionarMusicasFavoritas(musicas[377]);
        MusicasPreferidasVinicius.AdicionarMusicasFavoritas(musicas[4]);
        MusicasPreferidasVinicius.AdicionarMusicasFavoritas(musicas[6]);
        MusicasPreferidasVinicius.AdicionarMusicasFavoritas(musicas[1467]);

        MusicasPreferidasVinicius.ExibirMusicasFavoritas();

        MusicasPreferidasVinicius.GerarArquivoJson();

        MusicasPreferidasVinicius.GerarDocumentoTXTComAsMusicasFavoritas();

        //var MusicasPreferidasGabriela = new MusicasPreferidas("Gabriela");
        //MusicasPreferidasGabriela.AdicionarMusicasFavoritas(musicas[7]);
        //MusicasPreferidasGabriela.AdicionarMusicasFavoritas(musicas[735]);
        //MusicasPreferidasGabriela.AdicionarMusicasFavoritas(musicas[495]);
        //MusicasPreferidasGabriela.AdicionarMusicasFavoritas(musicas[113]);
        //MusicasPreferidasGabriela.AdicionarMusicasFavoritas(musicas[28]);
        //MusicasPreferidasGabriela.AdicionarMusicasFavoritas(musicas[1258]);

        //MusicasPreferidasGabriela.ExibirMusicasFavoritas();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"temos um problema: {ex.Message}");
    }
}
