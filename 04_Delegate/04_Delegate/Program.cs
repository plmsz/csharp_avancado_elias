using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Delegate
{
    internal class Program

    {
        delegate int Calcula(int a, int b);
        static void Main(string[] args)
        {
            /*var soma = Soma(10, 20);
            var subtrair = Subtrair(20, 10);*/
            //ponteiro para chamada de um metodo
            Calcula calc = new Calcula(Soma);
            int soma = calc(10, 20);

            Calcula calc1 = new Calcula(Subtrair);
            int subtrair = calc1(30,15);

            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Sub: " + subtrair);

            Console.ReadKey();
        }

        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
