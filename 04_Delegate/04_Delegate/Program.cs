using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Delegate
{
    internal class Program

    {
        public delegate int Calcula(int a, int b);
        public delegate void OcorrenciaDeOperacao(int r);
        public static event OcorrenciaDeOperacao AoOcorrerOperacao;
        public static void Main(string[] args)
        {
            /*var soma = Soma(10, 20);
            var subtrair = Subtrair(20, 10);*/

            AoOcorrerOperacao = MostraResultado;

            //ponteiro para chamada de um metodo
            Calcula calc = new Calcula(Soma);
            // Calcula calc = Soma; //não precisa do new TipoDoDelegate
            int soma = calc(10, 20);

            Calcula calc1 = new Calcula(Subtrair); // os metodos tem que ter a mesma assinatura do delegate (argumentos e tipo de retorno)
            int subtrair = calc1(30, 15);

            List<Calcula> lista = new List<Calcula>(); // coleção de delegates
            lista.Add(new Calcula(Soma));
            lista.Add(new Calcula(Subtrair));
            foreach (Calcula c in lista)
            {
                c(4, 1);
            }
            Console.ReadKey();
        }

        static int Soma(int a, int b)
        {
            int r = a + b;
            AoOcorrerOperacao.Invoke(r);
            //Console.WriteLine("Soma: " + r);
            return r;
        }

        static int Subtrair(int a, int b)
        {
            int r = a - b;
            //Console.WriteLine("Sub: " + r);
            AoOcorrerOperacao.Invoke(r);
            return r;
        }

        static void MostraResultado(int r)
        {
            Console.WriteLine($"Resultado {r}");
        }
    }
}
