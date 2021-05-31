# Split

## Sobre

Divide uma string em um array de strings, com base em delimitadores (caracteres ou strings que especificam onde as divisões deve ser feitas).

A classe String possui o método Split que podemos usar para dividir uma string em um array.

O método Split identifica substrings que são delimitados por um ou mais caracteres especificados em um array e então coloca as subtrings em um array de strings.

Portanto o método retorna um array de strings contendo substrings delimitadas por um caractere definido.

## Exemplos

```csharp
string palavras = Console.ReadLine();
//O Split vai dividir o que foi digitado em um array com base no delimitador que nesse caso é o espaço em branco
string[] palavraCortada = palavras.Split(' ');

string palavra1 = palavraCortada[0];
string palavra2 = palavraCortada[1];

Console.WriteLine(palavra1);
Console.WriteLine(palavra2);
```

```csharp
//Outra forma de usar o Split com Console.ReadLine() sem precisar declarar uma variavel antes
string[] palavraCortada = Console.ReadLine().Split(' ');

string palavra1 = palavraCortada[0];
string palavra2 = palavraCortada[1];

Console.WriteLine(palavra1);
Console.WriteLine(palavra2);
```

```csharp
string frase = "Marilda 20 1.74";
string[] vet = frase.Split(' ');
x = vet[0];

//Converte o valor digitado para int e guarda na variavel y
y = int.Parse(vet[1]);
//Converte o valor digitado para double e guarda na variavel z
z = double.Parse(vet[2], CultureInfo.InvariantCulture);
```

```csharp
string frase = "Estudando C#";
//O Split vai dividir a string em um array com base no delimitador que nesse caso é o espaço em branco
string[] fraseCortada = frase.Split(' ');
//Percorre os elementos do vetor e mostra na tela
foreach (var fraseCortada in fraseCortada)
{
    Console.WriteLine(fraseCortada);
}
```

