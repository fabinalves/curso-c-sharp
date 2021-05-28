# Casting

## Sobre
Casting é a conversão explícita de um tipo para outro.

O resultado do exemplo a seguir deveria ser 2.5 mas quando voce faz uma expressão com numeros inteiros o compilador entende que voce quer um resultado inteiro.

```csharp
int a, b;
double resultado;
a = 5;
b = 2;
resultado = a / b;
Console.WriteLine(resultado);

//Saída: 2
```

Para indicar pro compilador que voce quer um resultado double é necessario fazer o casting, conforme exemplo

```csharp
int a, b;
double resultado;
a = 5;
b = 2;
resultado = (double) a / b;
Console.WriteLine (resultado);

//Saída: 2.5
```


