using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.DesafiosModuloQuatro
{
    public static class ProgramaQuiz
    {
        public static void Run()
        {

            Dictionary<string, string> perguntaResposta = new Dictionary<string, string>()
            {
                { "Qual é a resposta para o universo a vida e tudo mais? ", "42" },
                { "Qual é o maior país em termos de extensão territorial do mundo? ", "Rússia" },
                { "Qual é a capital do estado do Acre? ", "Rio Branco" },
            };
            foreach (KeyValuePair<string, string> kvp in perguntaResposta)
            {
                Console.Write($"Pergunta: {kvp.Key}");
                string resposta = Console.ReadLine()!;

                if (resposta == kvp.Value)
                {
                    Console.WriteLine("CERTA RESPOSTA!");
                }
                else
                {
                    Console.WriteLine("Putz, você errou essa!");
                }
            }
        }
    }
}
