using System.ComponentModel.Design;

Console.WriteLine("********Exercicio Menor, Maior ou igual********");


Console.WriteLine("entre com o primeiro número: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("entre com o segundo número: ");
int segundoNumero = int.Parse(Console.ReadLine());

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