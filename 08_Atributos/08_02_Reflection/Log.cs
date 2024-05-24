using _08_02_Reflection.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_02_Reflection
{
    internal class Log
    {
        public static List<Usuario> usuarios = new List<Usuario>();
        public static void GravarUsuario(Usuario usuario)
        {
            usuarios.Add((Usuario) usuario.Clone()); // para poder modificar o objeto, é preciso clona-lo com IClonable, dessa forma não será mais uma referência na memoria
        }
        public static List<Carro> carros = new List<Carro>();
        public static void GravarCarro(Carro carro )
        {
            carros.Add(carro);
        }
        public static void ApresentarLog()
        {
            foreach (var usuario in usuarios)
            {
                Console.WriteLine("Nome {0}, Email: {1}, Senha: {2}", usuario.Nome, usuario.Email, usuario.Senha);
            }
            foreach (var carro in carros)
            {
                Console.WriteLine("Marca {0}, Modelo: {1}", carro.Marca, carro.Modelo); ;
            }
        }

    }
}
