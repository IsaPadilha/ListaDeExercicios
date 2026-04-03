// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digie o peso da prova: ");
int peso1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digie o peso da prova: ");
int peso2 = Convert.ToInt32(Console.ReadLine());

double media = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);

Console.WriteLine($"A média do aluno é: {media:F2}");

Console.ReadLine();
