```c#
string NomeDaVariavel = "Valor da variável";

NomeDaVariavel // "Valor da variável"
NomeDaVariavel += " 10"; //"Valor da variável 10";

delegate Referencia = Metodo1();

Referencia += Metodo2();

Referencia(); //Metodo1()+Metodo2

Classe Botao 
{
    Propriedades (Icones, Texto, Tamanho)
    Eventos (Clique, 2Clicks, Hover)
}

ClickEventArgs : EventArgs {
    PosicionamentoClick (x,y)
}

Clicar (this, new Click EventArgs(Curso.Posicao.x, Curso.Posicao.y))

Botao btn = new Botao("Salvar")

btn.Clicar = MetodoClicarParaSalvar()

public MetodoClicarParaSalvar(){}
```
# Conceito

Delegates funcionam como referências a métodos. Eles são como ponteiros para funções, mas com segurança de tipo adicional e recursos de orientação a objetos.
Delegates permitem a execução de métodos de forma tardia e chamadas flexíveis de métodos. Você pode decidir qual método executar em tempo de execução e até mesmo passar delegates como argumentos para outros métodos.

# Usos Comuns de Delegates:

Manipular eventos em interfaces gráficas (ex.: cliques de botão)
Implementar operações assíncronas (ex.: esperar a conclusão de uma requisição web)
Definir algoritmos de ordenação personalizados
Criar padrões de inversão de controle (ex.: injeção de dependência)