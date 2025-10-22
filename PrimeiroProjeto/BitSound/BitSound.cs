using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.BitSound
{
    public static class BitSoundProject
    {
        public static void Run()
        {
            // Bit Sound

            ExibirMensagemDeBoasVindas();
            ExibirOpcoesMenu();
            void ExibirMensagemDeBoasVindas()
            {
                Console.WriteLine(@"
█▄▄ █ ▀█▀ █▀ █▀█ █░█ █▄░█ █▀▄
█▄█ █ ░█░ ▄█ █▄█ █▄█ █░▀█ █▄▀
");
                Console.WriteLine("Bem vindo ao Bit Sound");
            }

            void ExibirOpcoesMenu()
            {
                Console.WriteLine(@"
Selecione uma opção:

1 - Registrar Banda
2 - Listar todas as bandas
3 - Avaliar uma banda
4 - Exibir a média de uma banda
0 - Encerrar programa

");
            }

            string opcaoEscolhida = "";
            int opcaoEscolhidaNumerica = -1;

            while (opcaoEscolhidaNumerica != 0)
            {
                Console.Write("Qual opção desja escolher: ");
                opcaoEscolhida = Console.ReadLine()!;
                opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
                switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                        break;
                    case 0:
                        Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Você escolheu uma opção inválida! Digite uma opção válida");
                        break;
                }
            }
        }
    }
}
