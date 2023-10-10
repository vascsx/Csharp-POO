using Mercadinho_Exercicio;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();       
        Console.WriteLine("Entre com os dados do produto: ");
        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();
        Console.Write("Preço: ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Quantidade no estoque: ");
        p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        
        Console.WriteLine("Dados do produto: " + );
    }   
}