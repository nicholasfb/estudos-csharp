using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercicios
{
    public static class DicionarioCarros
    {
        public static void Run()
        {
            Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

            foreach (KeyValuePair<string, List<int>> carros in vendasCarros) { 
                string nomeCarro = carros.Key;
                List<int> qtdVendasAno = carros.Value;

                double media = qtdVendasAno.Average();
                string qtdVendasFormatada = string.Join(", ", qtdVendasAno);

                Console.WriteLine($"Carro: {nomeCarro}, Vendas no ano: [{qtdVendasFormatada}], Média => {media}");
            }
        }
    }
}
