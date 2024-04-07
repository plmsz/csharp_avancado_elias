using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Validacao_Customizada
{
    internal class Usuario
    {
        [Required(ErrorMessage = "O campo 'Nome' é de preenchimento obrigatório")]
        public string Nome { get; set; }
        [Required()]
        public string Email { get; set; }
        [Required]
        [MinhaValidacao(ErrorMessage = "O campo senha deve possuir 10 caracteres")]
        public string Senha { get; set; }
    }
}
