Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("#####################################");
Console.WriteLine("Super conversão de temperatura🌡️ (graus celsius c° em fahrenheit f°) ");
Console.WriteLine("escreva o valor para ser convertido");
float.TryParse(Console.ReadLine(), out float cesius);
float resultado = (cesius * 9 / 5) + 32;
Console.WriteLine($"A temperatura 🌡️ é C°: {cesius}\nA conersão em F°: {resultado:f2}");

Console.WriteLine("#####################################");
Console.WriteLine("Agora, escreva o valor que será convertido de fahrenheit em Cesius ");
float.TryParse(Console.ReadLine(), out float fahrenheit);
float resultado1 = (fahrenheit - 32) * 5 / 9;
Console.WriteLine($"A temperatura 🌡️ é F°: {fahrenheit}\nA conersão em C°: {resultado1:f2}");
Console.WriteLine("#####################################");


Console.WriteLine("Agora, escreva o valor que será convertido de kelvin em celsius ");
float.TryParse(Console.ReadLine(), out float kelvin);
float resultado2 = (float)(kelvin - 273.15);
Console.WriteLine($"A temperatura 🌡️ é K°: {kelvin}\nA conersão em C°: {resultado2:f2}");
Console.WriteLine("#####################################");

Console.WriteLine("Agora, escreva o valor que será convertido de kelvin em fahrenheit  ");
float.TryParse(Console.ReadLine(), out float Kelvin);
float resultado3 = (float)(kelvin - 273.15)*9/5+32;
Console.WriteLine($"A temperatura 🌡️ é K°: {Kelvin}\nA conersão em F°: {resultado3:F2}");
Console.WriteLine("#####################################");

