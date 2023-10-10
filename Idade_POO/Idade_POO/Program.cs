namespace Idade_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa n1 = new Pessoa();
            Pessoa n2 = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            n1.name = Console.ReadLine();
            Console.Write("Digite o idade da primeira pessoa: ");
            n1.idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome da segunda pessoa: ");
            n2.name= Console.ReadLine();
            Console.Write("Digite o idade da segunda pessoa: ");
            n2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: " + n1.name);
            Console.WriteLine("Idade: " + n1.idade);
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: " + n2.name);
            Console.WriteLine("Idade: " + n2.idade);

            if (n1.idade > n2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + n1.name);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + n2.name);

            }
        }
    }
}