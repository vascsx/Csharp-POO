using System;
namespace Exercicio3
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int n4 = int.Parse(Console.ReadLine());


            if (n1 % 2 == 0 && n4 % 2 == 0) 
            {
                Console.WriteLine("Sao Multiplos");
            }
            if (n1 % 2 == 1 && n4 % 2 == 0 || n1 % 2 == 0 &&  n4% 2==1)
            {
                Console.WriteLine("Não multiplos");
            }
        }
    }
}



//Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
//Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
//ordem crescente ou decrescente.