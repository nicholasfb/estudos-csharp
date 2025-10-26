abstract class Funcionario
{
    public string Nome { get; }
    public string Cargo { get; protected set; }

    public Funcionario(string nome, string cargo)
    {
        this.Nome = nome;
        this.Cargo = cargo;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine(@$"Nome: {Nome}
Idade: {Cargo}");
    }
}