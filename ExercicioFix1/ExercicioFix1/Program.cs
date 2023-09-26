using System;
using System.Globalization;
namespace YourNamespace
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para saber se é negativo ou positivo: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine($"o {number} é positivo.");
            } else if (number < 0)
            {
                Console.WriteLine($"o {number} é negativo");
            }else
            {
                Console.WriteLine("Numero Invalido");
            }
        
        
        }
    }
}