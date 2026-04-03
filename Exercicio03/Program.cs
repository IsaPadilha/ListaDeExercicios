// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a temperatura desejada: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = (celsius * 1.8) + 32;

Console.WriteLine($"A temperatura convertida para a escala Fahreheit é: {fahrenheit}");

