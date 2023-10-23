using System;
using System.Globalization;


namespace Esfera_POO
{
    class Esfera_POO
    {
        static void Main(string[] args)
        {
            
            Console.Write("Entre com valor do raio: ");
            E.raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("CIRCUFERENCIA: " + E.Circuferencia().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + E.Volume().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: " + E.Pi.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}