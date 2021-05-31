# Parse

## Sobre
O métodos ``Parse()`` é usados para converter uma **representação de string de um número**.

## Exemplos

```csharp
string valor1 = "100";
//Converte a representação de string do numero 100 para int
int valor2 = int.Parse(valor1);
```

```csharp
string valor1 = "10,7";
//Converte a representação de string do numero 10,7 para double
double valor2 = double.Parse(valor1);
```

```csharp
string valor1 = "10,7";
//Converte a representação de string do numero 10,7 para float
float valor2 = float.Parse(valor1);
```

```csharp
string valor1 = 'A';
//Converte a representação de string do valor 'A' para char
char valor2 = char.Parse(valor1);
```

```csharp
//Quando voce digita algo o Console.ReadLine() retorna os dados lidos na forma de string.
//No exemplo a seguir o Parse pega o que foi digitado converte para int e guarda o valor na variavel valor1
int valor1 = int.Parse(Console.ReadLine());
```
