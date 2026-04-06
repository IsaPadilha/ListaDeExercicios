// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

int fatorial = 1;

for (int i = numero; i >= 1; i--)
{
    fatorial = fatorial * i;

    if (i > 1)
        Console.Write(i + " x ");
    else
        Console.Write(i + " = ");
}
Console.WriteLine($"{fatorial}");


