using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoClasses
{
    internal class Consulta
    {
        public string NomePaciente { get; set; }
        public string NomeMedico { get; set; }
        public DateTime DataConsulta { get; set; }

        public Consulta(string nomePaciente, string nomeMedico, DateTime dataConsulta)
        {
            NomePaciente = nomePaciente;
            NomeMedico = nomeMedico;
            DataConsulta = dataConsulta;
        }

        public void ReagendarConsulta(DateTime novaData)
        {
            DataConsulta = novaData;
            Console.WriteLine($"Consulta agendada para {DataConsulta.ToString("dd/MM/yyyy HH:mm")}");
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Paciente: {NomePaciente}");
            Console.WriteLine($"Médico: {NomeMedico}");
            Console.WriteLine($"Data da Consulta: {DataConsulta.ToString("dd/MM/yyyy HH:mm")}");
        }
    }
}
