using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[0].ExibirDetalhesDaMusica();

    } catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

