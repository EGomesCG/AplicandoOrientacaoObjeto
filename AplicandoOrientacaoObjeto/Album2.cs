using AplicandoOrientacaoObjeto;

class Album2
{
    private List<Musica> musicas = new List<Musica>();

    public Album2(string nome)
    {
        Nome = nome;
    }

    public Genero Genero { get; set; }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
   
    public void AddMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public  void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum: {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome} - Genero: {musica.Genero.Nome}");            
        }
        Console.WriteLine($"\nEste álbum tem a duração total: {DuracaoTotal} segundos\n");
    }
}