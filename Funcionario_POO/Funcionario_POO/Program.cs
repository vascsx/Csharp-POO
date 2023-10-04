using System;
using System.Globalization;

namespace Funcionario_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario p1 = new Funcionario();
            Funcionario s1 = new Funcionario();

            Console.Write("Digite o nome do primeiro funcionário: ");
            s1.Nome = Console.ReadLine();
            Console.Write("Digite o salario do primeiro funcionário: ");
            s1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Digite o nome do segundo funcionário: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Digite o salario do segundo funcionário: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


           double media = (s1.Salario + p1.Salario) / 2.00;


            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: " + s1.Nome);
            Console.WriteLine("Salario: " + s1.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Nome: " + p1.Nome);
            Console.WriteLine("Salario: " + p1.Salario.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("A média salarial é " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}