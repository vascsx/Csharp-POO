using System;
using System.Globalization;

namespace TrianguloEx_poo
{

    class Program
    {
    static void Main(string[] args)
    {
        Retangulo r = new Retangulo();
        Console.WriteLine("Digite a altura e largura do retangulo: ");
        r.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        r.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("AREA: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PERIMETRO: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL: " + r.Diagonal().ToString("F2",CultureInfo.InvariantCulture));
    }

    }
}
