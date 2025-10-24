using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.DesafiosModuloQuatro
{
    public static class ItensEstoque
    {
        public static void Run()
        {
            Dictionary<string, int> itensEstoque = new Dictionary<string, int>()
            {
                { "Café", 44},
                { "Garrafa de Leite", 60},
                { "Acholatado em pó", 30}
            };

            Console.WriteLine("Digite o nome de um item para saber a quantidade em Estoque");
            string itemEscolhido = Console.ReadLine()!;

            if (itensEstoque.TryGetValue(itemEscolhido, out int estoque))
            {
                Console.WriteLine($"O item {itemEscolhido} possui {estoque} unidades no estoque.");
            }
            else {
                Console.WriteLine($"O item {itemEscolhido} não está disponível no estoque no momento!");
            }
        }
    }
}
