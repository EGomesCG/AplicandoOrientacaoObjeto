using AplicandoOrientacaoObjeto;

//banda.Nome = "Talles Roberto";
////banda.AddAlbum(albumRenascer);
//

//Musica musica = new Musica(banda);
//musica.Nome = "Promessa";
////musica.Artista = "Renascer Praise";
//musica.Duracao = 381;
//musica.Disponiel = true;

//Musica musica2 = new Musica(banda);
//musica2.Nome = "Casa do Oleiro";
////musica2.Artista = "Ernani Azevedo";
//musica2.Duracao = 275;
//musica2.Disponiel = false;

//musica.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica(); 


//albumRenascer.Nome = "Renascer 17";




Banda banda = new Banda("Renascer Praise");

Genero genero = new Genero("Gospel");

Album2 albumRenascer = new Album2("Incomparavél");

Musica musica3 = new Musica(banda, genero, "Pelo Sangue")
{
    Duracao = 420,
    Disponiel = true,
};


Musica musica4 = new Musica(banda, "Promessa")
{
    Duracao = 225,
    Disponiel = false,
    Genero = new Genero("Romântica"),
};

Musica musica5 = new Musica(banda, genero, "A Resposta")
{
    Duracao = 445,
    Disponiel = true,
};


albumRenascer.AddMusica(musica3);
albumRenascer.AddMusica(musica4);
albumRenascer.AddMusica(musica5);
banda.AddAlbum(albumRenascer);

musica3.ExibirFichaTecnica();
musica4.ExibirFichaTecnica();
musica5.ExibirFichaTecnica();
albumRenascer.ExibirMusicasAlbum();
banda.ExibirDiscografia();
Console.WriteLine("\n\n................. Desafio 1 ..............");

Episodio ep1 = new(2, "Técnica de facilitação", 45);
ep1.AdicionarConvidados("João Jão");
Console.WriteLine(ep1.Resumo);

Console.WriteLine("\n\n................. Desafio 2 ..............");
Episodio ep2 = new(1, "Técnica de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flávia");

PostCast podcast = new("Daniel", "PodCast especial");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();

Console.ReadLine();