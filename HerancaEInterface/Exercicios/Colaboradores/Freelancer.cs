class Freelancer : Funcionario
{
    public decimal ValorProjeto { get; }
    public Freelancer(string nome, string cargo, decimal valorProjeto) 
        : base(nome, cargo)
    {
        this.ValorProjeto = valorProjeto;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine(@$"Nome: {Nome}
Idade: {Cargo}
Valor do Projeto: {ValorProjeto}");
    }
}