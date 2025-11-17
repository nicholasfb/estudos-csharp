using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoClasses
{
    internal class Retangulo
    {
        public decimal Altura { get; set; }
        public decimal Largura { get; set; }

        public Retangulo(decimal altura, decimal largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }
        public decimal CalcularArea()
        {
            return Altura * Largura;
        }
    }
}
