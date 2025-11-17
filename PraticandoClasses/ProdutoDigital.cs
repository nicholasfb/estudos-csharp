using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoClasses
{
    internal class ProdutoDigital
    {
        public string NomeProdutoDigital { get; set; }
        public decimal Preco { get; set; }
        public InformacaoTecnica InformacaoTecnica { get; set; }

        public ProdutoDigital(string nomeProduto, decimal preco, InformacaoTecnica info)
        {
            this.NomeProdutoDigital = nomeProduto;
            this.Preco = preco;
            this.InformacaoTecnica = info;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Produto Digital: {NomeProdutoDigital}");
            Console.WriteLine($"Preço: R$ {Preco}");
            InformacaoTecnica.ExibirInformacoes();
        }
    }
}
