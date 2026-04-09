Console.WriteLine("O astuto ancião conhecido como Mythrabnir, quer saber a área da sua magia, para isso ele precisa de você");
    Console.WriteLine("A área da sua magia é de um triângulo equilatero, digite um valor:");
double ndigitado = double.Parse(Console.ReadLine());
double resultado = ndigitado * ndigitado * 1.7 / 4;
Console.WriteLine($"Obrigado você ajudou o mago, com o {ndigitado}, a área do triângulo é {resultado}");