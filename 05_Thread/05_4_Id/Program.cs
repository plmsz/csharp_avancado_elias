using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_4_Id
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // main tem um threadId
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.Start(i);
            }
            Console.WriteLine("programa finalizado");
            Console.ReadKey();
        }

        static void ThreadRepeticao(object id)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Thread {id}, nº: {i}, id interno: {Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
