// A skeleton of a C# program
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace YourNamespace
{
    class Numero
    {
        static void Main(string[] args)
    {
        Console.Write("Digite um numero: ");
        double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while (n1 >= 0.00)
            {
        double raiz = Math.Sqrt(n1);
        Console.WriteLine(raiz.ToString("F2", CultureInfo.InvariantCulture));
        Console.Write("Digite um numero: ");
        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       }
            Console.WriteLine("Numero Negativo!!");
    }
}
}