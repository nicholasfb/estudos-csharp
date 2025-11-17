using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoClasses
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string nome, string cargo)
        {
            this.Nome = nome;
            this.Cargo = cargo;
        }

        public void Promover(string novoCargo)
        {
            if (Cargo.Equals(novoCargo, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Funcionário já está no cargo informado");
            }
            else
            {
                this.Cargo = novoCargo;
                Console.WriteLine($"Funcionário promovido para o cargo de {novoCargo}");
            }
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nCargo: {Cargo}";

        }
    }
}
