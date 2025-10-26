class Album
{
    private List<Musica> listaMusicas = new List<Musica>();
    public string NomeAlbum { get; set; }
    public int DuracaoTotalEmMinutos => listaMusicas.Sum(musica => musica.Duracao);

    public Album(string nomeAlbum)
    {
        this.NomeAlbum = nomeAlbum;
    }


    public void AdicionarMusica(Musica musica)
    {
        listaMusicas.Add(musica);
    }

    public void ListaMusicasAlbum()
    {
        listaMusicas.ForEach(musica => 
        Console.WriteLine(musica.Nome));

        Console.WriteLine($"Para ouvir esse álbum inteiro é necessário {DuracaoTotalEmMinutos} minutos");
    }
}