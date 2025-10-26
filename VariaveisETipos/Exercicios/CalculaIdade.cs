using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaveisETipos.Exercicios
{
    public static class CalculaIdade
    {
        public static void Run()
        {
            Console.WriteLine("Digite o ano que você nasceu: ");
            int anoNascimento = int.Parse(Console.ReadLine()!);

            int anoAtual = DateTime.Now.Year;

            Console.WriteLine($"Você nasceu em {anoNascimento} e tem {anoAtual - anoNascimento} anos");
            
        }
    }
}
