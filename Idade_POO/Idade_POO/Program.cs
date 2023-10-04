namespace Idade_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y,z,h;
            x = new Pessoa();
            y = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            x.A = Console.ReadLine();
            Console.Write("Digite o idade da primeira pessoa: ");
            y.C = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome da segunda pessoa: ");
            x.B = Console.ReadLine();
            Console.Write("Digite o idade da segunda pessoa: ");
            y.D = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: " + x.A);
            Console.WriteLine("Idade: " + y.C);
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: " + x.B);
            Console.WriteLine("Idade: " + y.D);

            if (y.C > y.D)
            {
                Console.WriteLine("Pessoa mais velha: " + x.A);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + x.B);

            }
        }
    }
}