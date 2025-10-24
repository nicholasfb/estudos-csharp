using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercicios
{
    public static class ExercicioDicionario
    {
        public static void mediaNotaDicionario()
        {
			Dictionary<string, Dictionary<string, List<int>>> notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
			{ "Ana", new Dictionary<string, List<int>> {
				{ "C#", new List<int> { 8, 7, 6 } },
				{ "Java", new List<int> { 7, 6, 5 } },
				{ "Python", new List<int> { 9, 8, 8 } }
			}},
			{ "Maria", new Dictionary<string, List<int>> {
				{ "C#", new List<int> { 6, 5, 4 } },
				{ "Java", new List<int> { 8, 7, 6 } },
				{ "Python", new List<int> { 6, 10, 5 } }
			}},
			{ "Luiza", new Dictionary<string, List<int>> {
				{ "C#", new List<int> { 2, 3, 10 } },
				{ "Java", new List<int> { 8, 8, 8 } },
				{ "Python", new List<int> { 7, 7, 7 } }
			}}
		};

			foreach(KeyValuePair<string, Dictionary<string, List<int>>> aluno in notasAlunos)  {
				string nomeAluno = aluno.Key;
				Console.WriteLine($"\nAluno: {nomeAluno}");

				Dictionary<string, List<int>> materias = aluno.Value;

				foreach (KeyValuePair<string, List<int>> materia in materias) {
					string nomeMateria = materia.Key;
					List<int> notas = materia.Value;

					double media = notas.Average();
					string notasFormatadas = string.Join(", ", notas);

					Console.WriteLine($" {nomeMateria}: [{notasFormatadas}] => Média: {media:F1}");
				}

			}
        }
    }
}
