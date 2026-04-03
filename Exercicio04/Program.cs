// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe o salário base: ");
double salarioBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o total de vendas: ");
double totalVendas = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o percentual de comissão: ");
double percentualComissao = Convert.ToDouble(Console.ReadLine());

double comissao = totalVendas * (percentualComissao / 100);

double salarioTotal = salarioBase + comissao;

Console.WriteLine($"O salário total é: {salarioTotal:F2}");
Console.ReadLine();
