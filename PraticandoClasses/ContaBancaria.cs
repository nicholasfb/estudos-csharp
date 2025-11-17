using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoClasses
{
    internal class ContaBancaria
    {

        public string NumeroConta { get; set; }
        public decimal Saldo { get; set; }

        public ContaBancaria(string numeroConta, decimal saldo)
        {
            this.NumeroConta = numeroConta;
            this.Saldo = saldo;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
            else
            {
                Console.WriteLine("Deposite um valor maior do que 0.");
            }
        }
        override public string ToString()
        {
            return $"Número da Conta: {NumeroConta}\nSaldo: R${Saldo:C}";
        }
    }
}
