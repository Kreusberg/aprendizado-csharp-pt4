using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Musica
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    // [] -> Anotação
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string? AnoString { get; set; }

    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }

    [JsonPropertyName("key")]
    public int Key {  get; set; }
    public string Tonalidade
    {
        get
        {
            return tonalidades[Key];
        }
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Duracao: {Duracao / 1000}");
        Console.WriteLine($"Genero musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }

}
