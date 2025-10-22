using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.DesafiosModuloUm
{
    public static class ValidaMedia
    {
        public static void Run() {
            Console.Write("Digite o valor inteiro da média de notas: ");
            string notaMedia = Console.ReadLine()!;
            int mediaNotaInt = int.Parse(notaMedia);

            if (mediaNotaInt >= 5)
            {
                Console.WriteLine("Nota suficiente para aprovação!");
            }
            else {
                Console.WriteLine("Reprovado!");
            }
        }
    }
}
