using ConsumindoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoAPI.Filters
{
    internal class LinqFilters
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(generos =>
            generos.Genero).Distinct().ToList();
            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas
                .Where(musica => musica.Genero!
                .Contains(genero))
                .Select(musica => musica.Artista)
                .Distinct()
                .ToList();
            Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");

            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
        {
            var musicasDoArtista = musicas
                .Where(musica => musica.Artista!
                .Equals(nomeDoArtista))
                .ToList();
            Console.WriteLine(nomeDoArtista);
            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica.Nome}");
            }

        }

        public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
        {
            var musicasDoAno = musicas
                .Where(musica => musica.Ano!.Equals(ano))
                .ToList();

            Console.WriteLine(ano);
            foreach (var musica in musicasDoAno)
            {
                Console.WriteLine($"- {musica.Nome} - {musica.Artista}");
            }
        }
    }
}
