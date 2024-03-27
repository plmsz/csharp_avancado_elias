using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_1_Var_Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object t1;
            t1 = "";
            object t2 = 12;
            t2 = "world";
           // t2.Nome = ""

            var v1 = "";
            var v2 = 12;
            //v2 = "hello" //erro por ter valor diferente
            //var v3; // erro por não ter valor

            int v3;

            dynamic d1;
            d1 = new Usuario { Nome = "Maria" };
            
            Console.WriteLine(d1.Nome);
            //Console.WriteLine(d1.Senha); // excessão em tempo de execução

            d1 = "Virei string";
            Console.WriteLine(d1);
            Console.ReadKey();
        }
        class Usuario
        {
            public string Nome { get; set; }
        }
    }
}
