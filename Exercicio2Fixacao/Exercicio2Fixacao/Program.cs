
//Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

using System;
namespace YourNamespace
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} é par");
            }
            else if (number % 2 == 1)
            {
                Console.WriteLine($"{number} é impar");
            }
            else {
                Console.WriteLine("Numero Invalido");
            }
        }
    }
}