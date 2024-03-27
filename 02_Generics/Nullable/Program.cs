using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int i = null; (erro) struct - por valor
            object o = null; // class por referncia

            //db - tem informaçãoes opcionais
            Nullable<int> Idade = null;
            int? Salario = null;
            
        }
    }
}
