double pesoHomem = 0.0;
double altura = 0.0;

Console.WriteLine("Digite o seu peso (Homem)");
pesoHomem = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o sua altura (Homem)");
altura = Convert.ToDouble(Console.ReadLine());

double pesoIdeal =  (72.7 * altura) - 58;

Console.WriteLine($"Seu peso ideal é: {pesoIdeal}");


