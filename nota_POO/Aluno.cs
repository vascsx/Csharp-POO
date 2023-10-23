using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nota_POO
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double Media()
        {
            return Nota1+Nota2+Nota3;
        }


        public double NotaFalta()
        {
            return 60 - Media();
        }
    }
}
