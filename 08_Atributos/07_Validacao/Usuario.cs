﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_01_Validacao
{
    class Usuario
    {
        //add resource
        [Required(ErrorMessage = "O campo 'Nome' é de preenchimento obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessageResourceType = typeof(Idiomas.Linguagem_PT), ErrorMessageResourceName = "MSG_OBRIGATORIO"), EmailAddress]
        public string Email { get; set; }
        [Required, StringLength(10, MinimumLength = 6)]
        public string Senha { get; set; }
    }
}
