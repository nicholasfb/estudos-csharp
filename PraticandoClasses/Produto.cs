using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoClasses
{
    internal class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }

        public bool EstaDisponivel { get; set; }

        public Produto(string nome, string descricao, decimal preco, int estoque)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
            this.Estoque = estoque;
            this.EstaDisponivel = estoque > 0;
        }

        
        override public string ToString()
        {
            return $"Nome: {Nome}\nDescrição: {Descricao}\nPreço: {Preco:C}\nEstoque: {Estoque}\nDisponível em estoque: {EstaDisponivel}";
        }
    }
}
