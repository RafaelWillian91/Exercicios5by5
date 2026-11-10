Console.WriteLine("*****Exercício para saber se é criança, adolescente, adulto ou idoso*******");



Console.WriteLine("Entre com a sua idade para saber a sua faixa etária");

int idade = int.Parse(Console.ReadLine());

switch (idade)
{
    case < 0: Console.WriteLine("Idade inválida");
        break;
    case <= 12: Console.WriteLine("Voçê é criança");
        break;
    case >= 13 and <=17 : Console.WriteLine("Voçê é adolescente");
        break;
    case >= 18 and <= 59: Console.WriteLine("Voçê é adulto");
        break;
    default: Console.WriteLine("Voçê é idoso");
        break;
}