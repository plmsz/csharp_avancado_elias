using _00_Biblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace _03_SerializarJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() {  Nome = "Maria", Email = "m@m.com", Cpf= "333.333.333.33" };
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string stringObjetoSerializado = serializer.Serialize(usuario);

            StreamWriter sw = new StreamWriter(@"C:\Users\paloma.souza\Downloads\csharp_avancado_elias\\01_Serializar\02_serializador.json");

            sw.WriteLine(stringObjetoSerializado);
            sw.Close();

        }
    }
}
