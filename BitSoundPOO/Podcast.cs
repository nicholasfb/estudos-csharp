class Podcast
{
    private List<Episodio> listaEpisodios = new List<Episodio>();
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios { get; set; }

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
        TotalEpisodios = listaEpisodios.Count();
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        listaEpisodios.Add(episodio);
        TotalEpisodios = listaEpisodios.Count();
    }

    public void ExibirDetalhesPodcast()
    {
        Console.WriteLine($"Podcast: {Nome}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine("Episódios:");
        foreach (Episodio episodio in listaEpisodios.OrderBy(episodio => episodio.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }   
        Console.WriteLine($"Total de Episódios: {TotalEpisodios}");
    }
}