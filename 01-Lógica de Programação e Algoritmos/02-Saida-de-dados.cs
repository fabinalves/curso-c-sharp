//Aula: Saída de dados em C#
using System;
using System.Globalization; //Biblioteca para utilizar o "CultureInfo.InvariantCulture"

namespace Projetos
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';
            //Comando para escrever na tela sem quebra de linha ao final
            Console.Write("Olá mundo!");
            //Comando para escrever na tela com quebra de linha ao final
            Console.WriteLine("Bom dia!");
            Console.WriteLine();
            //Comando para escrever na tela o valor da variavel x
            Console.WriteLine(x);
            //Comando para escrever na tela o valor da variavel x com duas casas decimais
            Console.WriteLine(x.ToString("F2"));
            //Comando para escrever na tela o valor da variavel x com quatro casas decimais
            Console.WriteLine(x.ToString("F4"));
            //Comando para escrever na tela o valor da variavel x com duas casas decimais separadas por ponto
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            //Comando para concatenar um texto com o valor da variavel x
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
            Console.ReadLine();
        }
    }
}
