class Disciplina
{
    public string Nome { get; set; }
    public List<Aluno> ListaAlunos { get; set; }
    public Professor professor { get; set; }

    public Disciplina() 
    {
        ListaAlunos = new List<Aluno>();
    }

    public string ExibeInformacoesDisciplina => @$"Nome da Disciplina: {this.Nome}
Professor: {this.professor.Nome}
Lista de Alunos: {string.Join(", ", this.ListaAlunos.Select(aluno => aluno.Nome)) }
";
}