using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoClasses
{
    internal class Filme
    {

        public string Titulo { get; set; }
        public int ClassificacaoEtaria { get; set; }

        public Filme(string titulo, int classificacaoEtaria)
        {
            this.Titulo = titulo;
            this.ClassificacaoEtaria = classificacaoEtaria;
        }

        public bool PermitirAcesso(int idadeUsuario)
        {
            return idadeUsuario >= ClassificacaoEtaria;
        }

        public string ExibirResultado(int idadeUsuario)
        {
            if(!PermitirAcesso(idadeUsuario))
            {
                return $"Acesso negado ao filme {Titulo}. Classificação etária: {ClassificacaoEtaria} anos.";
            }
            else
            {
                return $"Acesso permitido ao filme {Titulo}. Aproveite!";
            }
        }
    }
}
