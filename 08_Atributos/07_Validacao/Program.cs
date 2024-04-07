using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_01_Validacao
{
    internal class Program
    {
        // add referencia system.componentmodel.dataannotations
        static void Main(string[] args)
        {

            //Usuario usuario = new Usuario() {};
            //Usuario usuario = new Usuario() { Nome = "Ana" , Email = "a", Senha="12345"};
            Usuario usuario = new Usuario() { Nome = "Ana", Email = "a@m.com", Senha = "123456" };

            ValidationContext contexto = new ValidationContext(usuario);
            List<ValidationResult> resultados = new List<ValidationResult>();

            if (Validator.TryValidateObject(usuario, contexto, resultados, true) == false)
            {
                foreach (ValidationResult erro in resultados)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }

            Console.ReadKey();
        }
    }
}
