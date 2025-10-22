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
            List<string> listaBandas = new() { "Metallica", "Guns N' Roses", "Led Zeppelin" };

            // Bit Sound
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
                string opcaoEscolhida = "";
                int opcaoEscolhidaNumerica = -1;

                while (opcaoEscolhidaNumerica != 0)
                {
                    ExibirMensagemDeBoasVindas();
                    Console.WriteLine(@"
Selecione uma opção:

1 - Registrar Banda
2 - Listar todas as bandas
3 - Avaliar uma banda
4 - Exibir a média de uma banda
5 - Remover Banda da lista
0 - Encerrar programa

");
                    Console.Write("Qual opção deseja escolher: ");
                    opcaoEscolhida = Console.ReadLine()!;
                    opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
                    switch (opcaoEscolhidaNumerica)
                    {
                        case 1:
                            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                            RegistrarBanda();
                            break;
                        case 2:
                            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                            ListarBandas();
                            break;
                        case 3:
                            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                            break;
                        case 4:
                            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                            break;
                        case 5:
                            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                            RemoverBanda();
                            break;
                        case 0:
                            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                            Console.WriteLine("Encerrando o programa...");
                            Thread.Sleep(2000);
                            Console.WriteLine("ADEUS!!!");
                            break;
                        default:
                            Console.WriteLine("Você escolheu uma opção inválida! Digite uma opção válida");
                            break;
                    }
                }

            }

            void RegistrarBanda()
            {
                Console.Clear();
                Console.WriteLine("Registro de bandas!");
                Console.Write("Digite o nome da banda que deseja registrar: ");
                string nomeDaBanda = Console.ReadLine()!;
                listaBandas.Add(nomeDaBanda);
                Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
                Thread.Sleep(2000);
                Console.Clear();
            }

            void ListarBandas()
            {
                Console.Clear();
                if (listaBandas.Count == 0)
                {
                    Console.WriteLine("Não há nenhuma banda na lista, volte ao menu e registre uma banda.");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Listando Bandas...");
                    foreach (string banda in listaBandas)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine($"Banda - {banda}");
                    }
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            void RemoverBanda()
            {
                Console.Clear();
                Console.WriteLine("Bandas disponíveis para remoção\n");
                for (int i = 0; i < listaBandas.Count; i++)
                {
                    Console.WriteLine(i + " - " + listaBandas[i]);
                }
                Console.Write("\nSelecione uma das opções para remover uma banda da lista: ");
                string opcaoRemoveBanda = Console.ReadLine()!;
                int opcaoRemoveBandaInt = int.Parse(opcaoRemoveBanda);

                listaBandas.RemoveAt(opcaoRemoveBandaInt);
                Console.WriteLine("Banda removida com sucesso...");

                ListarBandas();
            }
        }
    }
}
