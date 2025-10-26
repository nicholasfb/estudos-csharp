class Musica 
{
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    //Propriedade. Convenção de nomenclatura PascalCase
    public bool Disponivel { get; set; }

    public Genero Genero { get; set; }

    //Construtor
    public Musica(Banda banda, string nome) 
    {
        this.Nome = nome;
        this.Artista = banda;

    }

    //Lambda(=>)
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista.Nome}";

    public void ExibirFichaTecnica() 
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração da música: {Duracao} minutos");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else {
            Console.WriteLine("Adquira o plano Plus#");
        }
    }
}