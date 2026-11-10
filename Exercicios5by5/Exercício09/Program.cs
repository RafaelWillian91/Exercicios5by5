Console.WriteLine("********Cálculo de um triângulo*********");


Console.WriteLine("Informe o primeiro lado do triângulo: ");
double ladoA = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo lado do triângulo: ");
double ladoB = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o terceiro lado do triângulo: ");
double ladoC = double.Parse(Console.ReadLine());

/*Verificar se é um triângulo:
    regra matemática chamada desigualdade triangular
        A soma de quaisquer dois lados precisa ser maior que o terceiro lado*/
if ( ladoA <= 0 || ladoB <= 0 || ladoC <= 0 || ladoA + ladoB <= ladoC ||
     ladoA + ladoC <= ladoB ||
     ladoB + ladoC <= ladoA)
{
    Console.WriteLine("Os lados não formam um triângulo");
    
}else if (ladoA == ladoB && ladoA == ladoC)
{
    Console.WriteLine("Os 3 lados são iguais. É um triângulo Equilátero");

}else if(ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
{
    Console.WriteLine("2 lados do triângulo são iguais. É um triângulo Isósceles");

}else
{
    Console.WriteLine("3 lados do triângulo são diferentes. É um triângulo Escaleno");
}