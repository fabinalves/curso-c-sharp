# Saída de dados

## Comandos para saída de dados

```csharp
//Comando para escrever na tela com quebra de linha
Console.WriteLine("Mensagem");
```

```csharp
//Comando para escrever na tela sem quebra de linha
Console.Write("Mensagem");
```

```csharp
//Comando para escrever na tela o valor de uma variavel
double x = 10.574868;
Console.WriteLine(x);
```

```csharp
//Comando para escrever na tela o valor de uma variavel com duas casas decimais
double x = 40.514284;
Console.WriteLine(x.ToString("F2"));
```

```csharp
//Comando para escrever na tela o valor de uma variavel com quatro casas decimais
double x = 60.514284;
Console.WriteLine(x.ToString("F4"));
```

```csharp
//Comando para escrever na tela o valor de uma variavel com duas casas decimais separadas por ponto
using System.Globalization;
double x = 10.574868;
Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
```

```csharp
//O operador de concatenação "+" serve para concatenar vários elementos em um mesmo comando
double x = 10.574868;
Console.WriteLine("RESULTADO = " + x);
Console.WriteLine("O valor do troco é " + x + " reais");
Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
```

