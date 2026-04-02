Console.WriteLine("Digite o comprimento da caixa retangular: ");
double comprimento = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a largura da caixa retangular: ");
double largura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a altura da caixa retangular: ");
double altura = Convert.ToDouble(Console.ReadLine());

double volume = comprimento * largura * altura;

Console.WriteLine($"O volume da caixa é: {volume:F2} cm");

Console.ReadLine();