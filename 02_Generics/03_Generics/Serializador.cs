using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace _02_Generics
{
    public class Serializador
    {
        public static void Serializar(object objeto)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\paloma.souza\Downloads\csharp_avancado_elias\02_Generics\" + objeto.GetType() + ".txt");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objetoSerializador = serializador.Serialize(objeto);

            sw.WriteLine(objetoSerializador);
            sw.Close();
        }
        public static T Deserializar<T>()
        {
            StreamReader sr = new StreamReader(@"C:\Users\paloma.souza\Downloads\csharp_avancado_elias\02_Generics\" + typeof(T) + ".txt");
           
            string conteudoDoArquivo = sr.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();

            T objeto = (T) serializador.Deserialize(conteudoDoArquivo, typeof(T));
             
            return objeto;

        }
    }
}
