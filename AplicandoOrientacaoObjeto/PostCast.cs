class PostCast
{
    public PostCast(string host, string nome) 
    {
        Host = host;
        Nome = nome;
    }
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    private List<Episodio> episodios = new();

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}");
        foreach (var episodio in episodios.OrderBy(e=>e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);            
        }
        Console.WriteLine($"Este podcast possui {TotalEpisodios} episodio(s)");
    }
}