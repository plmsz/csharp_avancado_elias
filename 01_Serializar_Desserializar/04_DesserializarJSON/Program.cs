using _00_Biblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace _04_DesserializarJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            StreamReader stream = new StreamReader(@"C:\Users\paloma.souza\Downloads\csharp_avancado_elias\\01_Serializar\02_serializador.json");
            string linhasDoArquivo = stream.ReadToEnd();
            Usuario usuario = (Usuario) serializer.Deserialize(linhasDoArquivo, typeof(Usuario));
            Console.WriteLine("{0}, {1}, {2}", usuario.Nome, usuario.Email, usuario.Cpf);
            Console.ReadKey();
        }
    }
}
