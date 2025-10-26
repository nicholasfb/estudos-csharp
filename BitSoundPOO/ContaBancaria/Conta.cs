class Conta 
{
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroConta { get; set; }
    public decimal Saldo { get; set; }
    public decimal Limite { get; set; }


    public void ExibeInformacoesConta() 
    {
        Console.WriteLine(@$"
Titular: {Titular.Nome}
Agência: {Agencia}
Número da Conta: {NumeroConta}
Saldo: {Saldo}
Limite: {Limite}
");
    }
}