Console.WriteLine("Olá! seja bem vindo a calculadora de IMC");
Console.WriteLine("Essa calculadora usa seu peso e altura para estimar se seu peso está adequado");
Console.Write("Digite seu peso:");
float peso;
float altura;
float.TryParse(Console.ReadLine().Replace(".", ","), out peso);
Console.Write("Digite seu Altura:");
float.TryParse(Console.ReadLine().Replace(".", ","), out altura);
float imc = peso / (float)Math.Pow(altura, 2);
Console.WriteLine($"{imc}");
if (imc < 18.5)
{
    Console.WriteLine("Você está em estado crítico de magreza, procure um profissional da área");
}
else if (imc > 18.5 && imc < 24.9) {
    Console.WriteLine("Você está em um nível bom, parabéns");
}
else if (imc > 25 && imc <29.9 )
{
    Console.WriteLine("Você está sobrepeso, procure um profissional da área");
}
else if (imc > 30 && imc < 39.9)
{
    Console.WriteLine("Você está obeso, procure um profissional da área");
}
else if (imc > 40)
{
    Console.WriteLine("Você está com obesidade grave, procure um profissional da área");
}