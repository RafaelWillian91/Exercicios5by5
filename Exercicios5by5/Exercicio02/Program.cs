using System.ComponentModel.Design;

Console.WriteLine("********Exercicio Menor, Maior ou igual********");


Console.WriteLine("entre com o primeiro número: ");
double numero = double.Parse(Console.ReadLine());

Console.WriteLine("entre com o segundo número: ");
double segundoNumero = double.Parse(Console.ReadLine());

if(numero > segundoNumero){
    Console.WriteLine("O primeiro número é maior");
}else if (numero < segundoNumero)
{
    Console.WriteLine("O segundo número é maior");
}
else
{
    Console.WriteLine("Os números são iguais");
}