using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloEx_poo
{
    internal class Retangulo
    {
        public double altura;
        public double largura;
 
        public double Area()
        {
           return largura * altura;
        }

        public double Perimetro()
        {
            return (largura * 2) + (altura * 2);
        }

        public double Diagonal()
        {
            return Math.Sqrt(largura*largura + altura * altura);
        }
    }
}
