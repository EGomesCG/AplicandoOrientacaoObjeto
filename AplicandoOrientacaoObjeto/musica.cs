using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicandoOrientacaoObjeto
{
    class Musica
    {
        public Banda Artista { get; }
        public string Nome { get; }
        public int Duracao { get; set; }
        public  bool Disponiel {get; set; }
        public Genero Genero { get; set; }
        public string DescricaoResumida => $"A musica {Nome} pertence à banda {Artista}.";
        //A idéia do construtor é: quando uma música é instanciada ela é obrigada passar o nome do Artista do objeto.
        //A caracteristica do construtor é: declaração e o tipo. Tem o abre e fecha parente e chaves
        public Musica(Banda artista)
        {
            Artista = artista;
        }
        public Musica(Banda artista, string nome)
        {
            Artista = artista;
            Nome = nome;
        }

        public Musica(Banda artista, Genero genero, string nome)
        {
            Artista = artista;
            Genero = genero;
            Nome = nome;
        }

        public Musica(string nome, int duracao, bool disponivel)
        {
            this.Nome = nome;
            this.Duracao = duracao;
            this.Disponiel = disponivel;
        }
        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            if(Disponiel) 
            {
                Console.WriteLine("Disponivel no plano.");
            }
            else
            {
                Console.WriteLine("Adquira o plano Plus+.");
            }
            Console.WriteLine("...............................");
        }
        
    }
}
