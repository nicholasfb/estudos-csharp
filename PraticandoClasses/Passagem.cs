using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoClasses
{
    internal class Passagem
    {
        public string Passageiro { get; set; }
        public string Destino { get; set; }

        public Passagem(string passageiro, string destino)
        {
            this.Passageiro = passageiro;
            this.Destino = destino;
        }

        public override string ToString()
        {
            return $"Passageiro: {Passageiro}\nDestino: {Destino}";
        }
    }
}
