using PrimeiroProjeto.DesafiosModuloQuatro;
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
            Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
            bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 5 });
            bandasRegistradas.Add("The Beatles", new List<int>());


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
                            AvaliarBanda();
                            break;
                        case 4:
                            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                            Thread.Sleep(1000);
                            CalculaMediaBanda();
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
                exibirTituloDaOpcao("Registrar Banda");
                Console.Write("Digite o nome da banda que deseja registrar: ");
                string nomeDaBanda = Console.ReadLine()!;
                //listaBandas.Add(nomeDaBanda);
                bandasRegistradas.Add(nomeDaBanda, new List<int>());
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
                    /*
                    exibirTituloDaOpcao("Listando Bandas");
                    foreach (string banda in listaBandas)
                    {
                        Console.WriteLine($"Banda - {banda}");
                        Thread.Sleep(1000);
                    }
                    */

                    foreach (KeyValuePair<string, List<int>> kvp in bandasRegistradas) {
                        List<int> valoresAvaliacoes = kvp.Value;
                        string valoresAvaliacoesFormatado = string.Join(", ", valoresAvaliacoes);
                        Console.WriteLine($"Banda - {kvp.Key}. Avaliações [{valoresAvaliacoesFormatado}]");
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            void AvaliarBanda()
            {
                Console.Clear();
                exibirTituloDaOpcao("Avaliar Banda");
                Console.Write("Digite o nome da banda que deseja avaliar: ");
                string nomeDaBanda = Console.ReadLine()!;
                if (bandasRegistradas.ContainsKey(nomeDaBanda))
                {
                    Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
                    int nota = int.Parse(Console.ReadLine()!);
                    bandasRegistradas[nomeDaBanda].Add(nota);
                    Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else {
                    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            void CalculaMediaBanda() {
                Console.Clear();
                exibirTituloDaOpcao("Cálculo de Avaliações de Banda");

                Console.Write("Qual é a banda que deseja verificar a média? ");
                string bandaEscolhida = Console.ReadLine()!;

                if (bandasRegistradas.TryGetValue(bandaEscolhida, out List<int> avaliacoes))
                {
                    Console.WriteLine($"A banda {bandaEscolhida} possui a média de avaliações de {avaliacoes.Average():F1}");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"A banda {bandaEscolhida} não está disponível no dicionário!");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                }


                /*foreach (KeyValuePair<string, List<int>> kvp in bandasRegistradas)
                {
                    if (kvp.Key.Equals(bandaEscolhida))
                    {
                        List<int> qtdAvaliacoes = kvp.Value;
                        double media = qtdAvaliacoes.Average();
                        Console.WriteLine($"A banda {kvp.Key} possui a média de {media:F1}");
                        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else {
                        Console.WriteLine("Essa banda não existe!");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }*/
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

            void exibirTituloDaOpcao(string titulo) {
                int quantidadeDeLetras = titulo.Length;
                string asteriscos = "".PadLeft(quantidadeDeLetras, '*');
                Console.WriteLine(asteriscos);
                Console.WriteLine(titulo);
                Console.WriteLine(asteriscos + "\n");
            }
        }
    }
}
