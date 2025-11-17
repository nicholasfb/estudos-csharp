using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoClasses
{
    internal class Pedido
    {

        public int NumeroPedido { get; set; }
        public string NomeCliente { get; set; }
        public string StatusPedido { get; set; }
        public Pedido(int numeroPedido, string nomeCliente, string statusPedido)
        {
            this.NumeroPedido = numeroPedido;
            this.NomeCliente = nomeCliente;
            this.StatusPedido = statusPedido;
        }

        public void AtualizarStatus(string novoStatus)
        {
            this.StatusPedido = novoStatus;
            Console.WriteLine("Status atualizado!");
        }

        public override string ToString()
        {
          return $"Pedido Nº: {NumeroPedido}, Cliente: {NomeCliente}, Status: {StatusPedido}";
        }
    }
}
