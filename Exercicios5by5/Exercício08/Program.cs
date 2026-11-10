Console.WriteLine("Cálculo aumento salárial");


Console.WriteLine("Entre com o valor do seu salário: ");
double salario = double.Parse(Console.ReadLine());

double novoSalario = 0;

if  (salario <= 2000)
{
    novoSalario = salario *= 1.15;
    Console.WriteLine("O seu salário teve um reajuste de 15%. O novo salário é: " + novoSalario);
}else if (salario <= 4000)
{
    novoSalario = salario *= 1.10;
    Console.WriteLine("O seu salário teve um reajuste de 10%. O novo salário é: " + novoSalario);
}
else
{
    novoSalario = salario *= 1.05;
    Console.WriteLine("O seu salário teve um reajuste de 5%. O novo salário é: " + novoSalario);
}