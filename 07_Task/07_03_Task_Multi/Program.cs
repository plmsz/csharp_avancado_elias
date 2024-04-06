using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _07_03_Task_Multi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> lista = new List<Task>();
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));

            //Task.WaitAny(lista.ToArray()); (espera até primeira task ser completada)
            Task.WaitAll(lista.ToArray());

            string[] enderecos = new string[] { "http://google.com.br", "https://jsonplaceholder.typicode.com/", "https://www.dailymail.co.uk/home/index.html" };

            var listaEnderecos = from end in enderecos select DownloadPagina(end);

            Task.WaitAll(listaEnderecos.ToArray());

            Console.WriteLine("Programa finalizado");
            Console.ReadLine();
        }
        static void Metodo01()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Valor de i: {i}, id: {Task.CurrentId}");
            }
        }

        static async Task DownloadPagina(string end)
        {
            WebClient web = new WebClient();
            string html = await web.DownloadStringTaskAsync(end);
            Console.WriteLine("Download realizado para a página " + end);
        }
    }
}
