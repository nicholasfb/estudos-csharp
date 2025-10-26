class Avaliacao
{
    public int Nota { get; private set; }
    public string Comentario { get; private set; }

    public Avaliacao(int nota, string comentario)
    {
        this.Nota = nota;
        this.Comentario = comentario;
    }

    public void Avaliar(int nota, string comentario)
    {
        this.Nota = nota;
        this.Comentario = comentario;
    }
}