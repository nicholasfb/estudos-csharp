using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.DesafiosModuloTres
{
    public static class SomaInteirosLista
    {
        public static void Run()
        {
            List<int> listaInteiros = new() { 20, 30, 40, 50 };

            int acumulador = 0;

            for (int i = 0; i < listaInteiros.Count; i++)
            {
                acumulador += listaInteiros[i];
            }

            Console.WriteLine($"A soma dos elementos inteiros é {acumulador}");
        }
    }
}
