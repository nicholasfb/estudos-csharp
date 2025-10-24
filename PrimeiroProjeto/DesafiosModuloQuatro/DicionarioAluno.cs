using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.DesafiosModuloQuatro
{
    public static class DicionarioAluno
    {
        public static void DicionarioAlunos()
        {
            Dictionary<string, List<int>> notasAlunos = new Dictionary<string, List<int>>
            {
                { "Jorginho", new List<int> { 7, 6, 4, 9 } },
                { "Luizinho", new List<int> { 4, 7, 6, 8 } },
                { "Fabinho", new List<int> { 9, 10, 7, 5 } }
            };

            foreach (KeyValuePair<string, List<int>> aluno in notasAlunos) { 
                string nomeAluno = aluno.Key;
                List<int> notas = aluno.Value;

                double media = notas.Average();
                string notasFormatadas = string.Join(", ", notas);

                Console.WriteLine($"{nomeAluno}: [{notasFormatadas}] -> Média: {media:F1}");
            }
        }
    }
}
