Console.OutputEncoding = System.Text.Encoding.UTF8;
int t1 = 1, t2 = 1, t3 = 0;


Console.Write("Digite o Número de termos:");
int.TryParse(Console.ReadLine()!, out int numerotermo);
Console.Write($"{t1}➡️{t2}➡️");
for (int i = 0; i < numerotermo; i++)
{
    t3 = t1 + t2;
    t1 = t2;
    t2 = t3;
    Console.Write($"{t3}➡️");
}
Console.Write("🎯");