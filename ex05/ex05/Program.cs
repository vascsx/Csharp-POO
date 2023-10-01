using System;
using System.Globalization;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a cultura para "en-US" (Inglês dos Estados Unidos)
            CultureInfo culture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = culture;

            Console.WriteLine("Digite o código do produto");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto");
            int quantidade = int.Parse(Console.ReadLine());
            double soma = 0.00;

            if (codigo == 1)
            {
                soma = 4 * quantidade;
                Console.WriteLine($"O preço de {quantidade} Cachorro Quente é {soma:C}");
            }
            else if (codigo == 2)
            {
                soma = 4.50 * quantidade;
                Console.WriteLine($"O preço de {quantidade} X-Salada é {soma:C}");
            }
            else if (codigo == 3)
            {
                soma = 5 * quantidade;
                Console.WriteLine($"O preço de {quantidade} X-Bacon é {soma:C}");
            }
            else if (codigo == 4)
            {
                soma = 2 * quantidade;
                Console.WriteLine($"O preço de {quantidade} Torrada Simples é {soma:C}");
            }
            else if (codigo == 5)
            {
                soma = 1.50 * quantidade;
                Console.WriteLine($"O preço de {quantidade} Refrigerante é {soma:C}");
            }
            else
            {
                Console.WriteLine("Código inválido. Digite um número de 1 a 5.");
            }
        }
    }
}
