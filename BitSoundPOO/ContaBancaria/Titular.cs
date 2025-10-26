public class Titular
{
    public string Nome { get; set; }
    public int Telefone { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }

    public string ExibeInformacoesTitular => @$"
Nome: {this.Nome}
Telefone: {this.Telefone}
CPF: {this.Cpf}
Email: {this.Email}
";
}