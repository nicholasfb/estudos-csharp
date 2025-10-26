class ClienteVip : Pessoa
{
    public string NivelFidelidade { get; private set; }
    public string CodigoVip { get; }
    public ClienteVip(string nome, int idade, string nivelFidelidade
        , string codigoVip) 
        : base(nome, idade)
    {
        this.NivelFidelidade = nivelFidelidade;
        this.CodigoVip = codigoVip;
    }

    public void ExibirInfoVip()
    {
        Console.Write("***************************");
        Console.WriteLine($@"
Bem-vindo, cliente VIP: {Nome}
Idade: {Idade}
Nível de Fidelidade: {NivelFidelidade}
Código VIP: {CodigoVip}");
        Console.Write("***************************\n");
    }

    public void AlteraNivelFidelidade(string novoNivelFidelidade)
    {
        this.NivelFidelidade = novoNivelFidelidade;
        Console.WriteLine($"Parabéns, o seu novo nível de fidelidade agora é {NivelFidelidade}");
    }
}