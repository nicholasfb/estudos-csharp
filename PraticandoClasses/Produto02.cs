using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoClasses
{
    internal class Produto02
    {
        public string Nome { get; set; }
        private int QuantidadeEstoque;

        public Produto02(string nomeProduto, int quantidadeInicialEstoque)
        {
            this.Nome = nomeProduto;
            this.QuantidadeEstoque = quantidadeInicialEstoque;
        }

        public void RemoverEstoque(int quantidade)
        {
            if(quantidade <= QuantidadeEstoque)
            {
                QuantidadeEstoque -= quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque.");
            }
        }

        public int ObterQuantidadeEstoque()
        {
            return QuantidadeEstoque;
        }
    }
}
