class Computador
{
    public Processador Processador { get; set; }
    public PlacaMae PlacaMae { get; set; }

    public void ExibirConfiguracao()
    {
        Console.WriteLine("Configuração do Computador:");
        Console.WriteLine($"Processador: {Processador.Marca} {Processador.Modelo}");
        Console.WriteLine($"Placa Mãe: {PlacaMae.Fabricante} - Socket: {PlacaMae.Socket}");
    }
}