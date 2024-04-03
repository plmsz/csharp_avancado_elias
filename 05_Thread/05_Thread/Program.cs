using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace _05_Thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();

            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("Main:" + i);
            }
            Console.ReadKey();
        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine($"NÚMERO: {i}");
            }
        }
    }
}
