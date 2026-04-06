// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite seu peso: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);

if (imc < 18.5)
{
    Console.WriteLine("Abaixo do peso.");
}
else if (imc >= 18.5 && imc < 25.0)
{
    Console.WriteLine("Peso normal.");
}
else if (imc >= 25.0 && imc <= 30.0)
{
    Console.WriteLine("Acima do peso.");
}
else
{
    Console.WriteLine("Obeso.");
}

Console.WriteLine($"Seu IMC é: {imc:F2}");
Console.ReadLine();
