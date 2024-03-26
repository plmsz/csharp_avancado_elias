using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_3_Group
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumero = { 1, 1, 1, 1, 4, 4, 3, 4, 5, 6, 6, 10, 9, 8 };

            var listaFiltrada = listaNumero.Distinct().OrderBy(x => x);

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var listaFiltrada2 = listaNumero.OrderBy(x => x).GroupBy(x => x).Select(x => x.Key);

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
