using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercicios
{
    public static class ExercicioString
    {
        public static void Run() {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("Olá, " + nome + "!");
            Console.WriteLine($"Outra forma do Console.WriteLine: {nome}!");
            Console.WriteLine("Mais uma forma do Console.WriteLine: {0}!", nome);
        }
    }
}
