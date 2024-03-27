
# LINQ 
-  Consulta Integrada à Linguagem, é um conjunto de tecnologias que integra recursos de consulta diretamente na linguagem C#

[Cheatsheet](https://medium.com/how-to-learn-net-in-2023/comprehensive-linq-cheat-sheet-3fb4a0e71204)

```C#
var produtos = new List<Produto>();

var produtosFiltrados = produtos.Where(p => p.Preco > 100);
```

```C#
var clientes = new List<Cliente>();

var clientesOrdenados = clientes.OrderBy(c => c.Nome);

```
```C#
List<Estudante> estudantes = new List<Estudante>()
{
  new Estudante { Nome = "Ana", AnoNascimento = 2000 },
  new Estudante { Nome = "Carlos", AnoNascimento = 1998 },
  new Estudante { Nome = "Beatriz", AnoNascimento = 2000 },
  new Estudante { Nome = "Daniel", AnoNascimento = 1995 },
};

// GroupBy ano de nascimento
var estudantesPorAno = estudantes.GroupBy(estudante => estudante.AnoNascimento);

// Imprimindo os grupos
foreach (var grupo in estudantesPorAno)
{
  Console.WriteLine($"Ano: {grupo.Key}");
  foreach (var estudante in grupo)
  {
    Console.WriteLine($"\t Nome: {estudante.Nome}");
  }
}


```
```C#
var produtos = new List<Produto>();

var nomesDosProdutos = produtos.Select(p => p.Nome);

```
```C#
List<string> nomes = new List<string>() { "Ana", "Carlos", "Beatriz", "Daniel" };
string filtro = "ri";

var resultado = nomes.Where(nome => nome.Contains(filtro));

foreach (var nome in resultado)
{
  Console.WriteLine(nome);
}

```
```C#
List<string> nomes = new List<string>() { "Ana", "Carlos", "Beatriz", "Daniel" };
string filtro = "ri";

var resultado = nomes.Where(nome => nome.Contains(filtro));

foreach (var nome in resultado)
{
  Console.WriteLine(nome);
}

```
```C#
// Lista de produtos
List<Produto> produtos = new List<Produto>()
{
  new Produto { Id = 1, Nome = "Caneta", CategoriaId = 1 },
  new Produto { Id = 2, Nome = "Lápis", CategoriaId = 2 },
  new Produto { Id = 3, Nome "Caderno", CategoriaId = 1 },
};

// Lista de categorias
List<Categoria> categorias = new List<Categoria>()
{
  new Categoria { Id = 1, Nome = "Material Escolar" },
  new Categoria { Id = 2, Nome = "Papelaria" },
};

// Unindo produtos e categorias pelo Id da categoria
var produtosComCategoria = produtos.Join(
  categorias,
  produto => produto.CategoriaId,
  categoria => categoria.Id,
  (produto, categoria) => new { NomeProduto = produto.Nome, NomeCategoria = categoria.Nome }
);

// Imprimindo os resultados
foreach (var item in produtosComCategoria)
{
  Console.WriteLine($"Produto: {item.NomeProduto}, Categoria: {item.NomeCategoria}");
}

```
# Sintaxe alternativa
```C#
// Lista de produtos
List<Produto> produtos = new List<Produto>()
{
  new Produto { Id = 1, Nome = "Caneta", CategoriaId = 1 },
  new Produto { Id = 2, Nome = "Lápis", CategoriaId = 2 },
  new Produto { Id = 3, Nome "Caderno", CategoriaId = 1 },
};

// Lista de categorias
List<Categoria> categorias = new List<Categoria>()
{
  new Categoria { Id = 1, Nome = "Material Escolar" },
  new Categoria { Id = 2, Nome = "Papelaria" },
};

// Unindo produtos e categorias
var produtosComCategoria = from produto in produtos
                          join categoria in categorias
                          on produto.CategoriaId equals categoria.Id
                          select new { NomeProduto = produto.Nome, NomeCategoria = categoria.Nome };

// Imprimindo os resultados
foreach (var item in produtosComCategoria)
{
  Console.WriteLine($"Produto: {item.NomeProduto}, Categoria: {item.NomeCategoria}");
}

```