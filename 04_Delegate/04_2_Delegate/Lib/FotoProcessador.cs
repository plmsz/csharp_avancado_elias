using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_2_Delegate.Lib
{
    internal class FotoProcessador
    {
        public delegate void FotoFiltroHandler(Foto foto);

        public static FotoFiltroHandler filtros;
        public static void Processar(Foto foto)
        {
            filtros(foto);
            /*var filtros = new FotoFiltro();
            filtros.Colorir(foto);
            filtros.PretoBranco(foto);
            filtros.GerarThumb(foto);
            filtros.Redimensionar(foto);*/

        }
    }
}
