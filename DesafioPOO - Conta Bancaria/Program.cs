using DesafioPOO___Conta_Bancaria;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();

        Console.Write("Entre com o número dda conta: ");
        pessoa.Id = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        pessoa.Nome = (Console.ReadLine());

        Console.Write("Haverá depósito inicial (s/n) ? ");
        pessoa.Escolha = (Console.ReadLine());

        if (pessoa.Escolha == "s")
        {
            Console.Write("Entre com um valor de depósito: ");
            pessoa.Deposito = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados da Conta: " + "Conta: " + pessoa.Id + "," + " Titular: " + pessoa.Nome + "," + " Saldo: " + pessoa.Deposito);
        }

        else if ( pessoa.Escolha == "n") 
        {
            Console.WriteLine("Dados da Conta: " + "Conta: " + pessoa.Id + "," + " Titular: " + pessoa.Nome + "," + " Saldo: " + pessoa.Deposito);
        }

        else
        {
            Console.WriteLine("Erro tente novamente: ");
            Console.Write("Haverá depósito inicial (s/n) ? ");
            pessoa.Escolha = (Console.ReadLine());
        }

        Console.Write("Entre com um valor para saque: ");
        pessoa.Saque = double.Parse(Console.ReadLine());
        pessoa.Deposito = pessoa.Deposito - pessoa.Saque;
        Console.WriteLine("Dados da Conta atualizados: \n" + "Conta: " + pessoa.Id + "," + " Titular: " + pessoa.Nome + "," + " Saldo: " + pessoa.Deposito);

    }
}