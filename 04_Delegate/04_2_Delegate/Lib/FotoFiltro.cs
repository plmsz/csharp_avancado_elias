using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_2_Delegate.Lib
{
    internal class FotoFiltro
    {
        public void Colorir(Foto foto)
        {
            Console.WriteLine("FotoProcessador > Colorir: " + foto.Nome); ;
        }
        public void GerarThumb(Foto foto)
        {
            Console.WriteLine("FotoProcessador > GerarThumb: " + foto.Nome);
        }
        public void PretoBranco(Foto foto)
        {
            Console.WriteLine("FotoProcessador > PretoBranco: " + foto.Nome);
        }
        public void Redimensionar(Foto foto)
        {
            Console.WriteLine("FotoProcessador > Redimensionar: " + foto.Nome);
        }
    }
}
