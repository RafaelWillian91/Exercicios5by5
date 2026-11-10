Console.WriteLine("*******Exercicio operacoes matemáticas*******");

Console.WriteLine("Informe o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

int resultadoAdicao =  num1 + num2;
Console.WriteLine("O resultado final da adição é " + resultadoAdicao);

int resultadoSubtracao = num1 - num2;
Console.WriteLine("O resultado final da subtração é " + resultadoSubtracao);

double resultadoDivisao = (double) num1 / num2;
Console.WriteLine("O resultado final da divisao é " + resultadoDivisao);

int resultadoMultiplicacao = num1 * num2;
Console.WriteLine("O resultado final da multiplicação é " + resultadoMultiplicacao);