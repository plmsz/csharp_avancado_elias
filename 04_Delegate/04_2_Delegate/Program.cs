using _04_2_Delegate.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_2_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foto foto = new Foto{ Nome ="perfil.jpg", TamanhoX= 1920, 
            TamanhoY = 1080};
            //perfil - tHumb
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processar(foto);
            //produtos - colorir + redimensionar
            Foto foto2 = new Foto
            {
                Nome = "produto.jpg",
                TamanhoX = 1920,
                TamanhoY = 1080
            };
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros += new FotoFiltro().Redimensionar;
            FotoProcessador.Processar(foto2);

            //albums
            Foto foto3 = new Foto
            {
                Nome = "album.jpg",
                TamanhoX = 1920,
                TamanhoY = 1080
            };
            FotoProcessador.filtros = new FotoFiltro().PretoBranco;
            FotoProcessador.Processar(foto3);

            Console.ReadKey();
        }
    }
}
