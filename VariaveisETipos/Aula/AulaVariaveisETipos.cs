using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaveisETipos.Aula
{
    public static class AulaVariaveisETipos
    {
        public static void Run() {
            //Declaração e inicialização da variável juntas
            int quantidadeProdutos = 42;

            //Declaração e inicialização da variável separadas
            int outrosProdutos;
            outrosProdutos = 43;


            //Inferência
            //Podemos utilizar o var para que o próprio compilador
            //realize a inferência do tipo de variável
            //IMPORTANTE: Necessário realizar a inicialização da variável
            var letra = 'A';

            Console.WriteLine(quantidadeProdutos);
            quantidadeProdutos++;

            Console.WriteLine(quantidadeProdutos);


            //Conversão de Tipos

            //Conversão ímplicita
            long quantidade2 = outrosProdutos;

            //Conversão explícita
            //A variável outrosProdutos é do tipo int
            byte quantidade3 = (byte)outrosProdutos;

            double valorUnitario = 30.0 / 4;
            Console.WriteLine(valorUnitario);

        }
    }
}
