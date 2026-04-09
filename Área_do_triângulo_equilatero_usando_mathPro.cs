Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("O astuto ancião conhecido como Mythrabnir, quer saber a área da sua magia, para isso ele precisa de você");
Console.Write("A área da sua magia é de um triângulo equilatero, digite um valor:");
float.TryParse(Console.ReadLine().Replace (".",","), out float ndigitado);
float resultado = (float)(Math.Pow(ndigitado, 2F)*Math.Pow(3, 1/2))/ 4;
Console.WriteLine($"Obrigado você ajudou o mago, com o número {ndigitado}, para o lado do triângulo, a área do 🔺 = {Math.Round(resultado,2)}");
