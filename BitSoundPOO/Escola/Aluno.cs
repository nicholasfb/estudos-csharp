class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<int> Notas { get; set; }

    public Aluno() 
    {
        Notas = new List<int>();
    }
}