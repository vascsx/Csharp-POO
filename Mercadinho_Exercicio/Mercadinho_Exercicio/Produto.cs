using System;
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

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco; 
            Quantidade = 10; // caso não preferir não precisava atribuir o valor 0, porque já é setado,
                            // porém caso queira outros valores tem que setar
        }

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
