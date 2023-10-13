using System.Text.Json;

namespace ScreenSound_04.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> listaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        listaDeMusicasFavoritas = new();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        listaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");

        foreach (var musica in listaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = listaDeMusicasFavoritas
        });

        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        //              Nome do arquivo  //dados
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivoJson foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}
