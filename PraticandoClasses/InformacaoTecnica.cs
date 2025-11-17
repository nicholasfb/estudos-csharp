using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoClasses
{
    internal class InformacaoTecnica
    {
        public decimal TamanhoMB { get; set; }
        public string SistemaOperacional { get; set; }

        public InformacaoTecnica(decimal tamanhoMB, string sistemaOperacional)
        {
            TamanhoMB = tamanhoMB;
            SistemaOperacional = sistemaOperacional;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Tamanho do Software: {TamanhoMB} MB");
            Console.WriteLine($"Sistema Operacional: {SistemaOperacional}");
        }
    }
}
