using _00_Biblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _01_S_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Converte o objeto em um arquivo xml

            Usuario usuario = new Usuario() { Nome = "Ana Souza", Cpf = "111.111.111", Email = "a@m.com" }; 
             //XmlSerializer serializador = new XmlSerializer(usuario.GetType());
             XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

             //@ para considerar tudo como string e nao precisar escapar caracteres especiais
            StreamWriter stream = new StreamWriter(@"C:\Users\paloma.souza\Downloads\csharp_avancado_elias\\01_Serializar\01_SerializaXML.xml");
             serializador.Serialize(stream,usuario);

            //Fazendo com uma lista
            List<Pessoa> pessoas = new List<Pessoa>
            {
                new Pessoa { Nome = "João Silva", Idade = 30 },
                new Pessoa { Nome = "Maria Oliveira", Idade = 25 }
            };

            XmlSerializer serializer = new XmlSerializer(typeof(List<Pessoa>));

            StreamWriter writer = new StreamWriter(@"C:\Users\paloma.souza\Downloads\csharp_avancado_elias\\01_Serializar\pessoas.xml");
             serializer.Serialize(writer, pessoas);
        }
    }
}
