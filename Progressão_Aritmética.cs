Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine($"Bem vindo a calculadora de PA");
Console.Write($"escreva até que número irá:");
int nqv = int.Parse(Console.ReadLine());
Console.Write($"escreva a razão:");
int razão = int.Parse(Console.ReadLine());

for (int i = 1; i <= nqv; i = i + razão)
{
    Console.Write($"{(i)}➡️");
}
Console.WriteLine("🎯");
