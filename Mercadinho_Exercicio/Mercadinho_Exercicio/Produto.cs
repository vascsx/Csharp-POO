﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace Mercadinho_Exercicio
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
           return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                + Quantidade
                + " unidades, Total: $" +
                ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}