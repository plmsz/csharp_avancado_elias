using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_02_Background
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando e iniciando a thread 1
            Thread thread1 = new Thread(ImprimirNumeros) { IsBackground = true };
            thread1.Start();

            // Criando e iniciando a thread 2
            Thread thread2 = new Thread(ImprimirLetras);
            thread2.Start();

            Console.WriteLine("Thread principal finalizada.");
            Console.ReadKey();
        }

        static void ImprimirNumeros()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Thread 1: {i}");
                Thread.Sleep(100); // Simula um atraso de 100 milissegundos
            }
        }

        static void ImprimirLetras()
        {
            for (char c = 'A'; c <= 'J'; c++)
            {
                Console.WriteLine($"Thread 2: {c}");
                Thread.Sleep(200); // Simula um atraso de 200 milissegundos
            }
        }
    }
}
