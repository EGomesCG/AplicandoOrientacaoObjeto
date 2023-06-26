class Banda
{
    private List<Album2> albums = new List<Album2>();
    public string Nome { get; }
    public Banda(string nome)
    {
        Nome = nome;
    }

    public void AddAlbum(Album2 album)
    {
        albums.Add(album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discográfia da banda: {Nome}");
        foreach (var album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} \nDuração: {album.DuracaoTotal} segundos");
        }
    }
}