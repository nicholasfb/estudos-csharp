class Episodio
{
    private static int contador = 0;
    private List<string> listaConvidados = new List<string>();
    public int DuracaoMinutos { get; }
    public int Ordem { get; }
    public string Titutlo { get; set; }
    public string Resumo => $"Episódio {Ordem}: {Titutlo} - Duração: {DuracaoMinutos} minutos - Convidados: {string.Join(", ", listaConvidados)}";

    public Episodio(string titulo, int duracaoMinutos) 
    {
        contador++;
        this.Titutlo = titulo;
        this.DuracaoMinutos = duracaoMinutos;
        this.Ordem = contador;
    }
    public void AdicionarConvidados(string convidado) 
    {
        listaConvidados.Add(convidado);
    }
}