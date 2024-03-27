using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "hi, HOWDY?";
            string transformada = frase.FirstOnlyToUpper();
            Console.WriteLine(transformada);
            Console.ReadKey();
        }
    }
}
