As variáveis são um conceito **fundamental**!

##💡 O que são Variáveis em Programação?Em programação, uma **variável** é um espaço de armazenamento nomeado na memória do computador. Pense nela como uma **caixa rotulada** onde você pode guardar um determinado tipo de informação (dados) para ser usada e manipulada pelo seu programa.

* **Nome:** É o rótulo da caixa (ex: `idade`, `nomeCliente`, `temperatura`). É como você se refere a ela no código.
* **Valor:** É o conteúdo que está dentro da caixa (ex: `25`, `"João Silva"`, `36.5`). Este valor pode **variar** (daí o nome *variável*) durante a execução do programa.
* **Tipo de Dado:** É o que define o *tipo* de informação que a caixa pode armazenar (ex: números inteiros, texto, números decimais, valores verdadeiro/falso). Em linguagens de tipagem forte como C#, o tipo deve ser declarado e é fixo.

**Declaração de uma Variável:** Consiste em dizer ao compilador qual será o **tipo de dado** e o **nome** da variável.

**Inicialização de uma Variável:** É o ato de atribuir um **valor inicial** à variável.

---

##💻 Exemplos de Variáveis em C#C# é uma linguagem *fortemente tipada*, o que significa que você deve especificar o tipo de dado da variável antes de usá-la.

###1. Tipos Numéricos| Tipo de Dado | Descrição | Exemplo em C# |
| --- | --- | --- |
| `int` | Armazena números **inteiros** (positivos ou negativos) sem casas decimais. | `int idade = 30;` |
| `double` | Armazena números de ponto flutuante, ou seja, com casas **decimais**. É o tipo mais comum para precisão geral. | `double preco = 19.99;` |
| `decimal` | Usado para cálculos financeiros ou que exigem alta precisão, pois minimiza erros de arredondamento. | `decimal salario = 4500.50m;` |

**Exemplo de Código:**

```csharp
public class ExemploNumerico
{
    public static void Main(string[] args)
    {
        // Declaração e inicialização de uma variável inteira
        int numeroDeAlunos = 45;

        // Declaração e inicialização de uma variável decimal (note o sufixo 'm')
        decimal valorImposto = 15.75m;
        
        // Declaração de um double e depois a atribuição de valor
        double media;
        media = 8.75; 

        // Demonstração da variável mudando de valor
        numeroDeAlunos = 46; 
        
        Console.WriteLine($"Total de alunos: {numeroDeAlunos}");
        Console.WriteLine($"Imposto cobrado: {valorImposto}");
        Console.WriteLine($"Média final: {media}");
    }
}

```

###2. Tipos de Texto| Tipo de Dado | Descrição | Exemplo em C# |
| --- | --- | --- |
| `string` | Armazena uma sequência de caracteres (texto). | `string nome = "Maria";` |
| `char` | Armazena um único caractere (letra, número ou símbolo) entre aspas simples. | `char primeiraLetra = 'A';` |

**Exemplo de Código:**

```csharp
public class ExemploTexto
{
    public static void Main(string[] args)
    {
        // Variável para armazenar o nome completo
        string nomeCompleto = "Ana Carolina Silva";

        // Variável para armazenar um caractere
        char statusInicial = 'A'; // 'A' de Ativo
        
        Console.WriteLine($"Nome do usuário: {nomeCompleto}");
        Console.WriteLine($"Status: {statusInicial}");
    }
}

```

###3. Tipo Lógico/Booleano| Tipo de Dado | Descrição | Exemplo em C# |
| --- | --- | --- |
| `bool` | Armazena um valor lógico que pode ser apenas **verdadeiro (`true`)** ou **falso (`false`)**. Essencial para tomada de decisões (`if/else`). | `bool estaLogado = true;` |

**Exemplo de Código:**

```csharp
public class ExemploBooleano
{
    public static void Main(string[] args)
    {
        // Variável booleana
        bool usuarioAtivo = true;

        // Variável que armazena o resultado de uma comparação
        bool ehMaiorDeIdade = (18 > 17); // O resultado será 'true'
        
        Console.WriteLine($"Usuário está ativo? {usuarioAtivo}");
        Console.WriteLine($"18 é maior que 17? {ehMaiorDeIdade}");
    }
}

```

---

O uso correto das variáveis, escolhendo o tipo de dado apropriado, é crucial para a eficiência e para evitar erros em seu código!