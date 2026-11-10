Console.WriteLine("*********Programa para saber os status de um aluno*********");

Console.WriteLine("Informe a primeira nota");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a segunda nota");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a tereceira nota");
double nota3 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a quarta nota");
double nota4 = double.Parse(Console.ReadLine());


double resultado = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine("A sua nota final é: " + resultado);

if (resultado >= 7)
{
    Console.WriteLine("Aluno aprovado");
}else if (resultado >= 5 && resultado < 6.9)
{
    Console.WriteLine("Aluno em recuperação");
}
else
{
    Console.WriteLine("Aluno reprovado");
}
