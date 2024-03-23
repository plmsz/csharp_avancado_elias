# Serialização

Serialização é o processo de converter um objeto em um formato que possa ser armazenado ou transmitido. Desserialização é o processo inverso, convertendo o formato serializado de volta em um objeto.

Em C#, existem várias maneiras de serializar e desserializar objetos. Uma maneira popular é usar o formato XML.

Serialização em XML
Para serializar um objeto em XML em C#, você pode usar a classe XmlSerializer.

Exemplo:

```C#
C#
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

Pessoa pessoa = new Pessoa
{
    Nome = "João Silva",
    Idade = 30
};

XmlSerializer serializer = new XmlSerializer(typeof(Pessoa));

using (StreamWriter writer = new StreamWriter("pessoa.xml"))
{
    serializer.Serialize(writer, pessoa);
}
```

O arquivo XML gerado:

```xml
<?xml version="1.0" encoding="utf-8"?>
<Pessoa>
  <Nome>João Silva</Nome>
  <Idade>30</Idade>
</Pessoa>
```

# Desserialização em XML

Para desserializar um objeto de um arquivo XML em C#, você pode usar a classe XmlSerializer.

Exemplo:

```C#
Pessoa pessoaDesserializada;

using (StreamReader reader = new StreamReader("pessoa.xml"))
{
    XmlSerializer serializer = new XmlSerializer(typeof(Pessoa));
    pessoaDesserializada = (Pessoa)serializer.Deserialize(reader);
}

Console.WriteLine(pessoaDesserializada.Nome); // Imprime "João Silva"
Console.WriteLine(pessoaDesserializada.Idade); // Imprime 30
```

As classes de serialização em C#, como XmlSerializer e JsonSerializer, suportam a serialização de coleções genéricas como List<T> e Dictionary<TKey, TValue>.

```C#
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

List<Pessoa> pessoas = new List<Pessoa>
{
    new Pessoa { Nome = "João Silva", Idade = 30 },
    new Pessoa { Nome = "Maria Oliveira", Idade = 25 }
};

XmlSerializer serializer = new XmlSerializer(typeof(List<Pessoa>));

using (StreamWriter writer = new StreamWriter("pessoas.xml"))
{
    serializer.Serialize(writer, pessoas);
}
```

```xml
<?xml version="1.0" encoding="utf-8"?>
<ArrayOfPessoa xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Pessoa>
    <Nome>João Silva</Nome>
    <Idade>30</Idade>
  </Pessoa>
  <Pessoa>
    <Nome>Maria Oliveira</Nome>
    <Idade>25</Idade>
  </Pessoa>
</ArrayOfPessoa>
```

# Serializando uma lista com JavaScriptSerializer:
```C#
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

List<Pessoa> pessoas = new List<Pessoa>()
{
    new Pessoa { Nome = "João Silva", Idade = 30 },
    new Pessoa { Nome = "Maria Oliveira", Idade = 25 }
};

JavaScriptSerializer serializer = new JavaScriptSerializer();
string jsonData = serializer.Serialize(pessoas);
Console.WriteLine(jsonData);
```
JavaScriptSerializer exigi a adição de uma referência ao assembly System.Web.Extensions em seu projeto.
Para cenários complexos, considere usar conversores personalizados com JavaScriptSerializer para lidar com tipos de dados específicos.
