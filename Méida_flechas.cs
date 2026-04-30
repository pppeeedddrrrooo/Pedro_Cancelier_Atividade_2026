Console.WriteLine("olá guilda, vamos calcular a força das flechas dos seus arqueiros");
int somaTotal = 0;
int[] danoflechas = new int[10];
danoflechas[0] = 10;
danoflechas[1] = 10;
danoflechas[2] = 11;
danoflechas[3] = 15;
danoflechas[4] = 19;
danoflechas[5] = 22;
danoflechas[6] = 76;
danoflechas[7] = 90;
danoflechas[8] = 91;
danoflechas[9] = 93;

foreach (int dano in danoflechas)
{
    somaTotal = somaTotal + dano; 
}
Console.WriteLine($" A méida da força das flechas é {somaTotal/10}");