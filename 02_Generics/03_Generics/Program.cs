using _02_Generics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { Marca = "Fiat", Modelo = "UNO" };
            Casa casa = new Casa() { Cidade = "São Paulo", Endereço = "Barra Funda" };
            Usuario usuario = new Usuario() { Nome = "Maria", Email = "m@m.com", Cpf = "333.333.333.33" };


            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();

            Console.WriteLine("Carro: {0} - {1}", carro2.Marca, carro2.Modelo);
            Console.WriteLine("Casa: {0} - {1}", casa2.Cidade, casa2.Endereço);
            Console.WriteLine("Carro: {0} - {1} - {3}",usuario2.Nome, usuario2.Email, usuario2.Cpf);

            Console.ReadKey();

        }
    }
}
