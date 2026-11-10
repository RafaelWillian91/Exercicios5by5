Console.WriteLine("*******Calculo ano Bissexto*********");

Console.WriteLine("Entre com o seu ano e nascimento para saber se é um ano bissexto: ");
int anoNascimento = int.Parse(Console.ReadLine());

// Regras do ano bissexto:
// 1. Deve ser divisível por 4 E NÃO ser divisível por 100.
// 2. OU deve ser divisível por 400 (exceção para anos seculares).
// Exemplos:
// 2024 -> Bissexto (divisível por 4, mas não por 100)
// 1900 -> Não bissexto (divisível por 100, mas não por 400)
// 2000 -> Bissexto (divisível por 400)

bool resultadoAnoBissexto = (anoNascimento % 4 == 0 && anoNascimento % 100 != 0) || (anoNascimento % 400 == 0);

if (resultadoAnoBissexto)
{
    Console.WriteLine("O ano " + anoNascimento+ " é bissexto!!");
}
else
{
    Console.WriteLine("O ano " + anoNascimento + " não é um ano bissexto");
}