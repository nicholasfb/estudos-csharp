class Banda 
{
    private List<Album> listaAlbuns = new List<Album>();
    public string Nome { get; set; }

    public Banda(string nome)
    {
        this.Nome = nome;
    }
    public void AdicionarAlbum(Album album) 
    {
        listaAlbuns.Add(album);
    }

    public void ExibirDiscografia() 
    {
        Console.WriteLine($"Discografia da banda {this.Nome}");
        foreach (Album album in listaAlbuns) 
        {
            Console.WriteLine($"Álbum: {album.NomeAlbum} ({album.DuracaoTotalEmMinutos} minutos)");
        }
    }
}