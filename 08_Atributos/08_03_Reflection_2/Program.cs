using _08_02_Reflection_2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_02_Reflection_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Usuario usuario = new Usuario() { Nome = "Ana", Email = "a@.m.com", Senha = "123456ab" };
            Log.Gravar(usuario.Clone());

            usuario.Nome = "Ana Banana";
            Log.Gravar(usuario.Clone());

            Carro carro = new Carro() { Marca = "FIAT", Modelo = "Uno" };
            Log.Gravar(carro);

            Log.ApresentarLog();

            Console.ReadKey();
        }
    }
}
