using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace StringExtension.Lib.Extensions // caso não esteja no mesmo namespace troca para System
namespace System
{
    public static class StringExtension //Não daria para herdar a classe String pois ela é selada
    {
        public static string FirstOnlyToUpper(this string value) // obrigatorio ser static
        {
            string primeira = value.Substring(0, 1).ToUpper();
            string segunda = value.Substring(1).ToLower();

            return primeira + segunda;
        }
    }
}
