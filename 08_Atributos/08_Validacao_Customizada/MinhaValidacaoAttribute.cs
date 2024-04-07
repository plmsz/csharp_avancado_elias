using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Validacao_Customizada
{
    internal class MinhaValidacaoAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return (((string)value).Length == 10);
        }
    }
}
