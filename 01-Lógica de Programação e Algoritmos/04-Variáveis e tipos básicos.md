# Variáveis e tipos básicos

## Variáveis

Uma variável é uma porção de memória (RAM) utilizada para armazenar dados durante a execução dos programas.

## Sintaxe utilizada para declarar variaveis


```csharp
//<tipo> <nome> = <valor inicial>;
int x = 10+20;
```

>Valor inicial é opcional

## Boa pratica

Sempre indique o tipo do número, se a expressão for de ponto flutuante (não inteira).

```csharp
//Para double use: .0
double b, B, h, area;

b = 6.0;
B = 8.0;
h = 5.0;

area = (b + B) / 2.0 * h;
Console.WriteLine(area);
```

```csharp
//Para float use: f
float b, B, h, area;

b = 6f;
B = 8f;
h = 5f;

area = (b + B) / 2f * h;
Console.WriteLine(area);
```

