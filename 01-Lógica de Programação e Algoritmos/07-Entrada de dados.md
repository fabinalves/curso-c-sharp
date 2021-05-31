# Entrada de dados

## Sobre

Entrada de dados é quando o programa ler os dados que o usuario digita.

## Comando
``Console.ReadLine();``

>Lê da entrada padrão até a quebra de linha e retorna os dados lidos na forma de string.

## Exemplos

```csharp
/*
O programa aguarda o usuario digitar algo e apertar ENTER, depois 
armazena o que foi digitado na variavel "frase".
*/
string frase = Console.ReadLine();
Console.WriteLine("Voce digitou: " + frase);
```

```csharp
using System.Globalization;
/*
O comando Console.ReadLine(); lê os dados em forma de string mas
para salvar o que foi digitado em uma variavel de outro tipo 
é necessario usar o comando Parse.
*/
int x = int.Parse(Console.ReadLine());
char y = char.Parse(Console.ReadLine());
double z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
```


