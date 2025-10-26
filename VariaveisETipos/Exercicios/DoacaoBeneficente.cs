using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaveisETipos.Exercicios
{
    public static class DoacaoBeneficente
    {
        public static void Run() 
        {
            Console.Write("Qual é o valor que deseja doar? R$");
            decimal valorDoado = decimal.Parse(Console.ReadLine()!);

            Console.Write("A doação é anônima? true para SIM e false para NÃO: ");
            bool doacaoAnonima = bool.Parse(Console.ReadLine()!);

            Console.Write("Para qual tipo de conta irá a doação? P para conta poupança ou C para conta corrente: ");
            char tipoConta = char.Parse(Console.ReadLine())!;

            Console.WriteLine($@"
Valor Recebido: R${valorDoado}
Doação Anônima: {doacaoAnonima}
Tipo de Conta: {tipoConta}
");
        }
    }
}
