// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Olá digite um número");
int.TryParse(Console.ReadLine(), out int x);
if (x > 5 || x<10)
{
    Console.WriteLine("Olá Dog 🐕🦮🐕‍🦺🐩🐶");
}
else {
    Console.WriteLine("fala peixe 🐟🐠🐡🦈");
}