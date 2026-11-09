Console.WriteLine("**********Exercicio Par ou Impar*************");

Console.WriteLine("Informe um número para saber se ele é par ou impar:");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
{
    Console.Write("O número é par");
}
else
{
    Console.Write("o numero é impar");
}