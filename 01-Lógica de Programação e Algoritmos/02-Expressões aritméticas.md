# Expressões aritméticas

## Sobre

Expressões aritméticas são aquelas cujo resultado da avaliação é do tipo numérico, seja ele 
inteiro ou real. Somente o uso de operadores aritméticos e variáveis numéricas, são permitidos 
em expressões deste tipo.

## Operadores aritméticos
```
+ Adição
- Subtração
* Multiplicação
/ Divisão
% Resto da divisão("mod")
```
## Precedência entre operadores

Os operadores ``* / %`` tem precedência maior que os operadores ``+ -``
>A expressão deve ser resolvida da esquerda para direita, quando a expressão tem operadores com a mesma precedência.

>Expressões com parênteses são resolvidas primeiro.

## Exemplos:


Nesse primeiro exemplo, como a expressão tem operadores com a mesma precedência a expressão deve ser resolvida da esquerda para direita.

```csharp
//Exemplo 1
2*6/3 = 4
```

No segundo exemplo, primeiro será resolvida a expressão ``2*4`` e depois ``3+2``.

```csharp
//Exemplo 2
3+2*4 = 11
```

No terceiro exemplo, como a expressão ``(3+2)`` está entre parênteses, ela será resolvida primeiro.

```csharp
//Exemplo 3
(3+2)*4 = 20
```


