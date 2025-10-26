class Professor
{
    public string Nome { get; set; }
    public List<string> DisciplinasLecionadas { get; set; }

    public Professor() 
    {
        DisciplinasLecionadas = new List<string>();
    }
}