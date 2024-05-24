using _08_02_Reflection.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_02_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Ana", Email = "a@.m.com", Senha = "123456ab" };
            Log.GravarUsuario(usuario);

            usuario.Nome = "Ana Banana";
            Log.GravarUsuario(usuario);
            Console.WriteLine("Log gravado");

            Log.ApresentarLog(); 


            Carro carro = new Carro() { Marca = "FIAT", Modelo = "Uno" };
            Log.GravarCarro(carro);

            Log.ApresentarLog();
            Console.WriteLine("Log gravado");

            Console.ReadKey();
        }
    }
}
