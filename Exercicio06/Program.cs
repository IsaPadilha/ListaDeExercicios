// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o valor de A: ");
double A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor de B: ");
double B = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor de C: ");
double C = Convert.ToDouble(Console.ReadLine());

if ((A + B) < C)
{
    Console.WriteLine("A soma de A + B é menor que C.");
}
else
{
    Console.WriteLine("A soma de A + B não é menor que C");
}