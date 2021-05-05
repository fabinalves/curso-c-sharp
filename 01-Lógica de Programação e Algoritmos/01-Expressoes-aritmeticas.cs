//Aula: Expressões aritméticas
//Operadores: + - * / %
using System;

namespace Projetos
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            //A expressão deve ser resolvida da esquera para direita quando os operadores tem a mesma precedência na expressão
            result = 2 * 6 / 3; 
            Console.WriteLine(result);//4
            //O operador * tem precedência maior que o operador +
            result = 3 + 2 * 4;
            Console.WriteLine(result);//11
            //Expressões com parênteses são resolvidas primeiro
            result = (3 + 2) * 4;
            Console.WriteLine(result);//20

            result = 60 / (3 + 2) * 4;
            Console.WriteLine(result);//48

            result = 60 / ((3 + 2) * 4);
            Console.WriteLine(result);//3
        }
    }
}
