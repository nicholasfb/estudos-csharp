class ColaboradorInterno : Funcionario
{
    public decimal Salario { get; private set; }
    public ColaboradorInterno(string nome, string cargo, decimal salario) 
        : base(nome, cargo)
    {
        this.Salario = salario;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine(@$"Nome: {Nome}
Idade: {Cargo}
Salario: {Salario}");
    }
}