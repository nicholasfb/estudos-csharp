using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.DesafiosModuloUm
{
    public static class ListaLinguagensProgramacao
    {
        public static void Run() { 
            List<string> listaLinguagensProgramacao = new List<string>();
            listaLinguagensProgramacao.Add("C#");
            listaLinguagensProgramacao.Add("Java");
            listaLinguagensProgramacao.Add("JavaScript");


            Console.WriteLine(listaLinguagensProgramacao.First());

            foreach(string linguagem in listaLinguagensProgramacao) {
                Console.WriteLine(linguagem);
            }

            Console.WriteLine("Digite um número inteiro para pesquisar o elemento nessa posição da lista: ");
            string numeroPosicao = Console.ReadLine()!;
            int numeroPosicaoInt = int.Parse(numeroPosicao);

            if (numeroPosicaoInt >= 0 && numeroPosicaoInt < listaLinguagensProgramacao.Count)
            {
                Console.WriteLine(listaLinguagensProgramacao[numeroPosicaoInt]);
            }
            else {
                Console.WriteLine("Essa posição não existe na lista.");
            }
            
        }
    }
}
