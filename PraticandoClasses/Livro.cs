using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoClasses
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public Livro(string titulo, string autor)
        {
            this.Titulo = titulo;
            this.Autor = autor;
        }
        override public string ToString()
        {
            return $"Título: {Titulo}\nAutor: {Autor}";
        }
    }
}
