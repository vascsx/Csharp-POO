using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Esfera_POO
{
    internal class Calculadora
    {
        public static double raio;
        public static double Pi = 3.14;

        public static double Circuferencia() { 
           return 2 * Pi * raio;
        }

        public static double Volume()
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }
    }
}
