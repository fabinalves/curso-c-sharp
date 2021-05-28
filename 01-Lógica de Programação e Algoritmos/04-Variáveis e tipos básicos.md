# Variáveis e tipos básicos

## Variáveis

Uma variável é uma porção de memória (RAM) utilizada para armazenar dados durante a execução dos programas.

## Sintaxe utilizada para declarar variaveis

``<tipo> <nome> = <valor inicial>;``

>Valor inicial é opcional

Ex.: int idade = 25;

## Boa pratica

Sempre indique o tipo do número, se a expressão for de ponto flutuante (não inteira).

Para double use: ``.0``

```csharp
double b, B, h, area;

b = 6.0;
B = 8.0;
h = 5.0;

area = (b + B) / 2.0 * h;
Console.WriteLine(area);
```

Para float use: ``f``

```csharp
float b, B, h, area;

b = 6f;
B = 8f;
h = 5f;

area = (b + B) / 2f * h;
Console.WriteLine(area);
```

