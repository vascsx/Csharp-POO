//Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
//(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
//ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
//para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
//este problema.//



using System;
using System.Globalization;

namespace nota_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno A = new Aluno();
            Console.Write("Nome do aluno: ");
            A.Nome = Console.ReadLine();
            Console.Write("Primeira nota: ");
            A.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Segunda nota: ");
            A.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Terceira nota: ");
            A.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
      


            Console.WriteLine("MEDIA: " + A.Media().ToString("F2", CultureInfo.InvariantCulture));

            if ( A.Media() >= 60)
            {
                Console.WriteLine("APROVADO");
            } 
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM: " + A.NotaFalta().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}