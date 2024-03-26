using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_3_Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Livro> listaLivro = new List<Livro>();
            listaLivro.Add(new Livro() { Id = 1, AutorId = 2, Titulo = "O ladrão de Raios" });
            listaLivro.Add(new Livro() { Id = 2, AutorId = 2, Titulo = "Mar dos montros" });
            listaLivro.Add(new Livro() { Id = 3, AutorId = 3, Titulo = "Ensaio sobre a cegueira" });
            listaLivro.Add(new Livro() { Id = 4, AutorId = 1, Titulo = "Frankestein" });

            List<Autor> listaAutor = new List<Autor>();
            listaAutor.Add(new Autor() { Id = 1, Nome = "Mary Shelley" });
            listaAutor.Add(new Autor() { Id = 2, Nome = "Rick Riordan" });
            listaAutor.Add(new Autor() { Id = 3, Nome = "José Saramago" });

            // var ListaJoin = listaLivro.Join(listaAutor, livros => livros.AutorId, autor => autor.Id, (livros, autor) => new { livros, autor });

            var ListaJoin = from livros in listaLivro join autor in listaAutor on livros.AutorId equals autor.Id select new { livros, autor };
            foreach (var item in ListaJoin)
            {
                Console.WriteLine("Livro: {0} de {1}", item.livros.Titulo, item.autor.Nome);
            }

            Console.ReadKey();
        }
    }
}
