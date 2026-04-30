Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Calculadora de números primos\nDigite o número:");
int.TryParse(Console.ReadLine()!, out int num);
int cont = 0;
for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        cont++;
    }
}
if (cont == 2)
{
    Console.WriteLine($"O número {num} é primo e par");
}
else if (cont == 2)
{
    Console.WriteLine($"O número {num} é primo");

}
else
{
    Console.WriteLine($"O {num} não é primo");
}