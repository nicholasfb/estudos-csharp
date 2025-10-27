using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsumindoAPI.Models
{
    internal class Personagem
    {
        [JsonPropertyName("name")]
        public string? Nome { get; set; }
        [JsonPropertyName("gender")]
        public string? Genero{ get; set; }
        [JsonPropertyName("culture")]
        public string? Cultura{ get; set; }
        [JsonPropertyName("aliases")]
        public List<string>? Apelidos { get; set; }

        public void ExibirDetalhesDoPersonagem()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Cultura: {Cultura}");
            Console.WriteLine("Apelidos: ");
            if (Apelidos != null && Apelidos.Any())
            {
                foreach (var apelido in Apelidos)
                    Console.WriteLine($"- [{apelido}]");
            }
            else
            {
                Console.WriteLine("Sem apelidos.");
            }
        }
    }
}
