Console.WriteLine("*******Calculo ano Bissexto*********");


Console.WriteLine("Entre com o seu ano e nascimento para saber se é um ano bissexto: ");
int anoNascimento = int.Parse(Console.ReadLine());

/** Regra principal: O ano deve ser divisível por 4 (o resto da divisão deve ser zero).
• Exceção dos séculos: Se o ano terminar em 00 (como 1900 ou 2000), ele não é bissexto, a menos que...
• Exceção da exceção: O ano terminado em 00 precisa ser divisível por 400 **/

bool resultadoAnoBissexto = (anoNascimento % 4 != 0 && anoNascimento % 100 == 0) || (anoNascimento % 400 == 0);

if (resultadoAnoBissexto)
{
    Console.WriteLine("O ano é bissexto!!");
}
else
{
    Console.WriteLine("Não é um ano bissexto");
}