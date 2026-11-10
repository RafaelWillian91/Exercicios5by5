Console.WriteLine("*****Exercício para classificação de faixa etária*******");



Console.WriteLine("Entre com a sua idade para saber a sua faixa etária");

int idade = int.Parse(Console.ReadLine());

//padrão relacional (<, >, <=, >=) combinado com padrão lógico ( and, or e not para combinar ou negar padrões)
//(relational pattern e logical pattern), disponível desde o C# 9

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