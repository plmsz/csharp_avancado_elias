using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 3, 9, 4, 630, 20, 60, 90, 80, 50 };
            //select representa o valor que quer apresenta, tal como no sql
            var listaFiltrada = lista.Where(x => x > 10).OrderByDescending(x => x).Select(x => x);
              foreach (var item in listaFiltrada)
              {
                  Console.WriteLine(item);
              }

            Console.WriteLine();
            var listaFiltrada2 = from x in lista where x > 10 orderby x ascending select x;
            foreach (var item in listaFiltrada2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
