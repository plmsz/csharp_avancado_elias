using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_5_Sleep_Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio do programa");
            Thread.Sleep(3000);
            Console.WriteLine("Termino do progama");

            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();
            t1.Join();

            Console.WriteLine("Fim do fluxo");

            Console.ReadKey();
        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"NÚMERO: {i}");
            }
        }
    }
}
