
string nomeMidas = "Midas";
var vidasMidas = 1000;
string nomeDragao = "dragão";
var vidasDragao = 1500;
var danoAdaga = 300;


Console.WriteLine("Olá, seja bem vindo ao HoleWorld!!!".ToUpper());
Console.WriteLine($"Um {nomeDragao} está atcando o castelo da princesa,que midas sonha em casar.".ToUpper());
Console.WriteLine($"Então {nomeMidas} batalhará contra o {nomeDragao} para salvar a princesa.".ToUpper());
Console.WriteLine($"{nomeMidas} possui {vidasMidas} de vida e o {nomeDragao} {vidasDragao} de vida.".ToUpper(System.Globalization.CultureInfo.CurrentCulture));
Console.WriteLine($"Dano da adaga é de {danoAdaga}.".ToUpper(System.Globalization.CultureInfo.CurrentCulture));
Console.WriteLine($"{nomeMidas} pula no {nomeDragao} e corta as costas dele com sua adaga!".ToUpper(System.Globalization.CultureInfo.CurrentCulture));
vidasDragao -= danoAdaga;
Console.WriteLine($"Deixando o {nomeDragao} com {vidasDragao} de vida".ToUpper(System.Globalization.CultureInfo.CurrentCulture));
Console.WriteLine($"{nomeDragao} pega {nomeMidas} de suas costas e arremesa longe, contra uma parede do castelo, tirando metade de sua vida".ToUpper(System.Globalization.CultureInfo.CurrentCulture));
vidasMidas /= 2;
Console.WriteLine($"Deixando {nomeMidas} com {vidasMidas} de vida".ToUpper(System.Globalization.CultureInfo.CurrentCulture));
Console.WriteLine($"{nomeMidas} pega sua poção de vida e bebe, recuperando 500 de vida ".ToUpper(System.Globalization.CultureInfo.CurrentCulture));
vidasMidas += 500;
Console.WriteLine($"{nomeMidas} com sua poção volta a ter {vidasMidas} de vida".ToUpper(System.Globalization.CultureInfo.CurrentCulture));
danoAdaga *= 2;
Console.WriteLine($"{nomeMidas} Esperto toma outra poção, que dobra o dano da sua adaga, deixando com {danoAdaga}!!!".ToUpper(System.Globalization.CultureInfo.CurrentCulture));
Console.WriteLine($"{nomeMidas} vai para seu golpe final;".ToUpper(System.Globalization.CultureInfo.CurrentCulture));
vidasDragao -= 2 * danoAdaga;
Console.WriteLine(($"corre em diração ao {nomeDragao} deslizando por baixo dele, escalando-o, subindo até a nuca e dando 2 cortes com sua adaga".ToUpper(System.Globalization.CultureInfo.CurrentCulture)));
Console.WriteLine($"deixando o {nomeDragao} com {vidasDragao} de vida".ToUpper(System.Globalization.CultureInfo.CurrentCulture));
Console.WriteLine($"Ganhando a batalha e salvando a princesa".ToUpper(System.Globalization.CultureInfo.CurrentCulture));

Console.ReadKey();
