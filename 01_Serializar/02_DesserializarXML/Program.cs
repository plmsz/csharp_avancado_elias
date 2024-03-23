using _00_Biblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _02_DesserializarXML
{
    internal class Program
    {

        static void Main(string[] args)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            StreamReader stream = new StreamReader(@"C:\Users\paloma.souza\Downloads\\csharp_avancado_elias\\01_Serializar\01_SerializaXML.xml");
            //type object, por isso precisa de casting para transformar para Usuario
            Usuario usuario = (Usuario) serializador.Deserialize(stream);

            Console.WriteLine("Usuario (Nome): {0}, CPF: {1}, Email {2}", usuario.Nome, usuario.Cpf, usuario.Email);
            
            Console.ReadKey();

        }


    }
}
