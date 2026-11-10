Console.WriteLine("Calculo IMC");


Console.WriteLine("Entre com o seu peso: ");
double peso = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com a sua altura em centímetros (ex: 175): ");
double altura = (double.Parse(Console.ReadLine()) / 100);

double resultadoIMC = peso / (altura * altura);

Console.WriteLine("seu IMC é " + resultadoIMC);

if (resultadoIMC < 18.5)
{
    Console.WriteLine("Voçê está abaixo do peso");
}
else if (resultadoIMC < 25.0)
{
    Console.WriteLine("Seu peso está normal");
}
else if (resultadoIMC < 30)
{
    Console.WriteLine("Voce está com sobrepeso");
}
else if (resultadoIMC < 35.0)
{
    Console.WriteLine("Obesidade grau I");
}
else if (resultadoIMC < 40.0)
{
    Console.WriteLine("Obesidade grau II");
}
else
    Console.WriteLine("Obesidade grau III (Mórbida)");