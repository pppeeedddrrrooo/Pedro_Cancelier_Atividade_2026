Console.WriteLine("O impiedoso vilão repleto de luxuria e maldades de luxo está tentando invadir seu castelo");
Console.WriteLine("Ele tentará por 3 vezes causar impacto no portão com sua tecnologia");
Console.WriteLine("Digite quanto de força você tem:");

float.TryParse(Console.ReadLine(), out float valor);
for (int i = 0; i < 3; i++)
{
    valor = (float)valor * valor;

}

if (valor > 400)
{
    Console.WriteLine($"Você tem {valor} de força, e salvou seu reino");
}
else
        {
    Console.WriteLine($"Você tem {valor} de força e  não conseguiu salvar seu reino, e sucumbiu aos seus desejos com dores no corpo pelo resto da vida");

}


