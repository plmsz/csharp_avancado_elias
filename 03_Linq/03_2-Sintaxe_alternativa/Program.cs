using _03_2_LinqObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_2_Sintaxe_alternativa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> list = new List<Usuario>();
            list.Add(new Usuario() { Nome = "Ana", Email = "a.gmail.com" });
            list.Add(new Usuario() { Nome = "Bia", Email = "b.outlook.com" });
            list.Add(new Usuario() { Nome = "Lia", Email = "l.mailgun.com" });
            list.Add(new Usuario() { Nome = "Sia", Email = "gata_s.gmail.com" });
            list.Add(new Usuario() { Nome = "Mia", Email = "m.gmail.com" });

            //var listaFiltrada = list.Where(x => x.Email.EndsWith(".gmail.com")).OrderBy(x => x.Nome);

            var listaFiltrada = list.Where(x => x.Email.Contains(".gmail.com"));

            //var listaFiltrada = from x in list where x.Email.Contains(".gmail.com") orderby x.Nome select x;

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item.Nome + " " + item.Email);
            }

            Console.ReadKey();

        }
    }
}
