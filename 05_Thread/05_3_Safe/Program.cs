using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_3_Safe
{
    internal class Program
    {
        // I/O - lentos - imrpessora, tela, rede, impressora
        //FIFO - first in first out
        static int Rede = 0;
        static object variavelDeControle = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("DateInitial" + DateTime.Now);
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.IsBackground = true;
                t1.Start();
            }
            Console.ReadKey();
        }
        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (variavelDeControle)
                {
                    Console.WriteLine($"NÚMERO: {i}");
                    Rede++;
                }
            }
            Console.WriteLine("DateTime" + DateTime.Now);

        }
    }
}
