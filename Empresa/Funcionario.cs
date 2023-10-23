﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Empresa
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem){
            SalarioBruto = (SalarioBruto * porcentagem / 100.00) + SalarioBruto;
            }

        public override string ToString()
        {
            return Nome + ", R$ " +
                  SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);  
        }
    }
}
