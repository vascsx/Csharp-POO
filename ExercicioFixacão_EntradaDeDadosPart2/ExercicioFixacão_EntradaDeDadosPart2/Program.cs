Console.WriteLine("Entre com seu nome completo: ");
string nome = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa");
int quarto = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preço do produto");
double preco = double.Parse(Console.ReadLine());
Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha) :");

string[] vet = Console.ReadLine().Split(' ');
string p1 = vet[0];
string p2= vet[1];
string p3 = vet[2];

 

Console.WriteLine(nome);
Console.WriteLine(quarto);
Console.WriteLine($"{preco:F2}");
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);
