using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.DesafiosModuloTres
{
    public static class OperacaoMatematica
    {
        public static void Run(double numeroA, double numeroB) {
            CalculaOperacoesMatematicas(numeroA, numeroB);

            void CalculaOperacoesMatematicas(double numeroA, double numeroB) {
                Console.WriteLine(@$"
Números passados:
Número A: 
Adição: {numeroA + numeroB}
Subtração: {numeroA - numeroB} 
Multiplicação: {numeroA * numeroB}
Divisão: {numeroA / numeroB}
");
            }
        }
    }
}
