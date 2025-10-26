class ProdutoDigital : Produto, IExpiravel
{
    private string linkDownload;
    public DateTime DataCompra { get; }


    public ProdutoDigital(string nome, string descricao,
        decimal preco, string imagem, string linkDownload)
        : base(nome, descricao, preco, imagem)
    {
        this.LinkDownload = linkDownload;
    }

    public string LinkDownload
    {
        get
        {
            return linkDownload;
        }
        set
        {
            if (value.Length > 0)
            {
                this.linkDownload = value;
            }
        }
    }

    public bool EstaExpirado() 
    {
        return DateTime.Now > DataCompra.AddYears(2);
    }
}