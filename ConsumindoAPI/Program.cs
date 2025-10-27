using ConsumindoAPI.Filters;
using ConsumindoAPI.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    //Com GetStringAsync é possível fazer requisições GET
    //de forma assíncrona e consumir todo o conteúdo do endpoint
    //antes de passar para a próxima linha de código.
    //Await aguarda a tarefa ser concluída antes de continuar a execução.
    try
    {
        string resposta = await client.GetStringAsync(
        "https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        List<Musica> musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilters.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenadas(musicas);
        //LinqFilters.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");
        //LinqFilters.FiltrarMusicasDeUmArtista(musicas, "Billie Eilish");
        //LinqFilters.FiltrarMusicasPorAno(musicas, "2018");

        var musicasPreferidasDoNico = new MusicasPreferidas("Nicholas");
        musicasPreferidasDoNico.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoNico.AdicionarMusicasFavoritas(musicas[355]);
        musicasPreferidasDoNico.AdicionarMusicasFavoritas(musicas[1425]);
        musicasPreferidasDoNico.AdicionarMusicasFavoritas(musicas[99]);
        musicasPreferidasDoNico.AdicionarMusicasFavoritas(musicas[42]);

        musicasPreferidasDoNico.ExibirMusicasFavoritas();

        musicasPreferidasDoNico.GerarArquivoJson();
    }
    catch (HttpRequestException e)
    {
        Console.WriteLine($"Erro ao acessar o endpoint: {e.Message}");
    }

    //Consumindo Game of Thrones API
    /*
    try
    {
        for (int i = 580; i <= 590; i++)
        {
            string resposta = await client.GetStringAsync(
            $"https://www.anapioficeandfire.com/api/characters/{i}");
            var personagens = JsonSerializer.Deserialize<Personagem>(resposta)!;
            Console.WriteLine($"\nDetalhes do personagem {personagens.Nome}:");
            personagens.ExibirDetalhesDoPersonagem();
        }
    }
    catch (HttpRequestException e)
    {
        Console.WriteLine($"Erro ao acessar o endpoint: {e.Message}");
    }
    */
}