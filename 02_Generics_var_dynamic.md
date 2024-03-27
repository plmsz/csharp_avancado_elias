# Generics

Os genéricos possibilitam projetar classes e métodos que adiam a especificação de um ou mais parâmetros de tipo até que você use a classe ou o método em seu código.

```C#
public interface IProduto
{
    int Id { get; set; }
    string Nome { get; set; }
    decimal Preco { get; set; }

    // Métodos adicionais...
}

```C#
public class ProdutoFisico : IProduto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public int Estoque { get; set; }

    // Métodos adicionais...
}

public class ProdutoDigital : IProduto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public string UrlDownload { get; set; }

    // Métodos adicionais...
}

```

```C#
public class RepositorioGenerico<T> where T : IProduto
{
    private List<T> _produtos;

    public RepositorioGenerico()
    {
        _produtos = new List<T>();
    }

    public void Adicionar(T produto)
    {
        _produtos.Add(produto);
    }

    public T ObterPorId(int id)
    {
        return _produtos.Find(p => p.Id == id);
    }

    // Métodos adicionais...
}

```

```C#
var repositorioProduto = new RepositorioGenerico<ProdutoFisico>();

// Adicionar produtos
var produto1 = new ProdutoFisico
{
    Nome = "Camiseta",
    Preco = 50.00,
    Id = 100,
    Esoque = 11
};

repositorioProduto.Adicionar(produto1);

```

# Var e dynamics

```c#
namespace _02_1_Var_Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object t1 = "";
            object t2 = 12;
            t2 = "world";
           // t2.Nome = ""

            var v1 = "";
            var v2 = 12;
            //v2 = "hello" //erro por ter valor diferente
            //var v3; // erro por não ter valor

            int v3;

            dynamic d1;
            d1 = new Usuario { Nome = "Maria" };
            
            Console.WriteLine(d1.Nome);
            //Console.WriteLine(d1.Senha); // excessão em tempo de execução

            d1 = "Virei string";
            Console.WriteLine(d1);
            Console.ReadKey();
        }
        class Usuario
        {
            public string Nome { get; set; }
        }
    }
}

```