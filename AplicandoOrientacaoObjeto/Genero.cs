using AplicandoOrientacaoObjeto;

class Genero
{
    private List<Musica> musica = new List<Musica>();

    public Genero(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public void ExibirGenero() 
    {
        Console.WriteLine($"Genero desta música: {Nome}");
    }
}