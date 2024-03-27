# Extension Methods

No C# nada mais são do que classes estáticas que podem viver fora das suas classes e ainda assim adicionar funcionalidade a mesma.

```C#
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
```
