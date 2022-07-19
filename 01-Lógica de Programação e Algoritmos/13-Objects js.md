# Objetos

## Sobre

Objetos são como uma espécie de "super variáveis" que armazenam uma "coleção de valores" referenciados por nome, e que podem ser recuperados para serem utilizados em diversas outras partes de um programa. Em JavaScript praticamente qualquer tipo de dado é um objeto.

## Informações
- A maneira mais simples (e recomendável) de se criar objetos em JavaScript é usando o que chamamos de objeto literal — ao pé da letra, escrevemos o conteúdo do objeto conforme o criamos, diferente de objetos instanciados de classes.
```javascript
// Um objeto literal é composto por um par de chaves "{ }", que envolve uma ou mais propriedades. Cada propriedade segue o formato "nome: valor" e devem ser separadas por vírgula.
const car = {type:"Fiat", model:"500", color:"white"};
```
- Outra forma de escrever objetos com quebras de linhas:
```javascript
const person = {
  firstName: "John",
  lastName: "Doe",
  age: 50,
  eyeColor: "blue",
  fullName : function() {
    return this.firstName + " " + this.lastName;
  }
};
```
- É uma prática comum declarar objetos com a palavra-chave const.
- Propriedades de um objeto:
```javascript
/*
Objeto: car
Propriedade1: type
Valor da propriedade1: Fiat
Propriedade2: info
Valor da propriedade2: function() {return this.type;}
*/
const car = {
    type:"Fiat", 
    info : function() {
    return this.type;
  }
```
- Acessando propriedades de um objeto
```javascript
// Após ter criado um objeto, você vai precisar acessar os valores que ele armazena. Podemos acessar (ou se preferir: "recuperar") os valores guardados em um objeto, de duas maneiras: utilizando notação de ponto ou notação de colchetes. Veja um exemplo:

// notação de ponto (é recomendável utilizar a notação de ponto, por ser mais simples de ler e escrever)
person.firstName;
 
// notação de colchetes
person["firstName"];
```
- Acessando metodos de um objeto

```javascript
// Como os métodos são funções, você deve adicionar um par de parênteses - ()

// notação de ponto
person.fullName();
 
// notação de colchetes
person["fullName"]();
```
- Alterando valores de propriedades
```javascript
// Para alterar o valor de uma propriedade basta acessar a propriedade que deseja alterar, utilizando a notação de ponto, e atribuir o novo valor à ela.
person.firstName = "Pablo";
person.lastName = "Simplicio";
```
- Adicionando propriedades a objetos ja criados
```javascript
// Podemos adicionar novas propriedades e métodos aos nossos objetos mesmo após ter criado eles. A sintaxe é a mesma utilizada para alterar valores.
person.friends["friend1", "friend2", "friend3"];
```
- Deletando propriedades
```javascript
// Podemos deletar uma propriedade ou método de um objeto utilizando o operador delete seguido pelo nome da propriedade
delete person.age;
```



