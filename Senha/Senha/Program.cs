using System;
using System.Globalization;


namespace Program
{
    class Senha
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Acesso não Permitido!");
                Console.Write("Digite um numero: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
        }
    }
}