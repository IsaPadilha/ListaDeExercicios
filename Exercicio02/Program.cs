// See https://aka.ms/new-console-template for more information

Console.WriteLine("Informe a quilometragem inicial do veículo: ");
double kmInicial = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a quilometragem final do veículo: ");
double kmFinal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Em litros, informe a quantidade de combustível consumida durante a viagem: ");
double combustivel = Convert.ToDouble(Console.ReadLine());

double distancia = kmFinal - kmInicial;

double consumo = combustivel / distancia;

Console.WriteLine($"Você consumiu cerca de {consumo:F2} litros por quilômetro em sua viagem!");