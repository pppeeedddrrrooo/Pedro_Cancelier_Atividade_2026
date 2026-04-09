//Linha para por emoji
using System.ComponentModel.Design;
using System.Threading.Tasks.Sources;

Console.OutputEncoding = System.Text.Encoding.UTF8;
//Classes


string NomeDragão = ("Dragão vermelho");
string classeAnão = ("Anão");
string classeElfo = ("Elfo");
string classeClérigo = ("Clérigo");
string classeMago = ("Mago");
string classeGuerreiro = ("Guerreiro");
string classeDruida = ("Druida");
string classeTroll = ("Troll");




//Introdução do mundo
Console.WriteLine("Seja bem vindo! Um grande Dragão Vermelho 🐉 despertou e está ameaçando o reino!\n Você foi o aventureiro escolhido pela guilda para avaliar se um herói está apto a enfrentá-lo ou se virará churrasco. ");
Console.WriteLine("Primeiro escolha o nome e do seu Herói");
string NomeHerói = (Console.ReadLine());

//Para escolher o nome e classe
Console.WriteLine($"Ólá {NomeHerói} se prepare para enfrentar o {NomeDragão}");
Console.WriteLine($"Agora escolha sua classe, dependendo da sua escolha você terá atributos diferentes\n escolha com sabedoria");

//Variaveis das classes
Console.WriteLine($"1. {classeAnão}");
Console.WriteLine($"2. {classeTroll}");
Console.WriteLine($"3. {classeClérigo}");
Console.WriteLine($"4. {classeMago}");
Console.WriteLine($"5. {classeGuerreiro}");
Console.WriteLine($"6. {classeDruida}");
Console.WriteLine($"7. {classeElfo}");
string escolhaclasse = Console.ReadLine() ?? "1";

//Para poder escolher as opções q aparecem em baixo
string classeEscolhida = escolhaclasse switch
{
    "1" => classeAnão,
    "2" => classeTroll,
    "3" => classeClérigo,
    "4" => classeMago,
    "5" => classeGuerreiro,
    "6" => classeDruida,
    "7" => classeElfo

    // Para o usuário definir seu personagem
};
Console.WriteLine($"Agora sim {NomeHerói} o {classeEscolhida}🪪");

//Nível do personagem (número inteiro)
Console.WriteLine("Agora que você escolheu sua classe e seu nome, escolha o nivel que você quer começar, escolha um número inteiro");
int nivelHerói = int.Parse(Console.ReadLine());
Console.WriteLine($"Certo então você é nível {nivelHerói}🛡️");

//Hp do personagem (número interio ou decimal)
Console.WriteLine($"Até agora você está indo muito bem, agora escreva seu HP (pontos de vida)");
int PontosVida = int.Parse(Console.ReadLine());
Console.WriteLine($"Boa escolha, você tem {PontosVida} pontos de vida ❤️");

//Mana do Personagem (número ineiro)
Console.WriteLine($"calma, está quase acabando, Agora escreva quanto de mana você tem");
int mana = int.Parse(Console.ReadLine()); ;
Console.WriteLine($"você tem {mana} de mana🧪");

//Ouro do personagem (Número inteiro ou decimal)
Console.WriteLine($"Por último escolha seu ouro ");
double Ouro = double.Parse(Console.ReadLine());
Console.WriteLine($"você tem {Ouro} de Ouro🪙");

//Classe do inimigo
Console.WriteLine($"Agora vamos se aventurar\n  mas antes escolha a classe do inimigo, que seja diferente da sua");
Console.WriteLine($"1. {classeAnão}");
Console.WriteLine($"2. {classeElfo}");
Console.WriteLine($"3. {classeClérigo}");
Console.WriteLine($"4. {classeMago}");
Console.WriteLine($"5. {classeGuerreiro}");
Console.WriteLine($"6. {classeDruida}");
Console.WriteLine($"7. {classeTroll}");
string escolhainimiga = Console.ReadLine() ?? "1";

//Para poder escolher as opções q aparecem em baixo (switch)
string classeinimiga = escolhainimiga switch
{
    "1" => classeAnão,
    "2" => classeTroll,
    "3" => classeClérigo,
    "4" => classeMago,
    "5" => classeGuerreiro,
    "6" => classeDruida,
    "7" => classeElfo


};
//condição, não pode escolher a mesma raça que a sua
if (classeinimiga != classeEscolhida)
{

    Console.WriteLine($"A raça do seu vilão é  {classeinimiga}");
}
//Se escolheram a mesma raça qua a de si próprio, te pede para escolher outra
else
{
    Console.WriteLine("Ops! parece que você escolheu a mesma raça que a sua, Escolha uma raça diferente da sua");
    escolhainimiga = Console.ReadLine() ?? "1";
}

//Para poder escolher as opções q aparecem em baixo
classeinimiga = escolhaclasse switch
{
    "1" => classeAnão,
    "2" => classeElfo,
    "3" => classeClérigo,
    "4" => classeMago,
    "5" => classeGuerreiro,
    "6" => classeDruida,
    "7" => classeTroll
};

Console.WriteLine($" Agora que você sabe qual será a classe do seu inimigo\n Você será avaliado para ver se está apto a entrar na guilda dos Aventureiros");
Console.WriteLine("está pronto?");
Console.ReadLine();

if (classeEscolhida == classeTroll)
{
    Console.WriteLine($"VOCÊ É UM {classeEscolhida}??????? SAIA JA DAQUI AGORAAA!!!");
}
else
{
    if (nivelHerói < 5)
        Console.WriteLine("Você ainda é muito fraco, treine e volte quando estiver em um nível mais alto");
    else
        Console.WriteLine($"\nVOCÊ PASSOU NO TESTE! Seja bem vindo a guilda dos {classeEscolhida}s!");
}
Console.WriteLine($"\nAgora que você entrou para guilda dos {classeEscolhida}s e sabe seus status\nVamos calcular seu poder base.");
Console.WriteLine($"para calcular seu poder base, será feita essa operação: Poder Base = (Nível * 10) + (HP / 2) - 5");
Console.WriteLine($"\n Está pronto?");
Console.ReadLine();
var poderBase = (nivelHerói * 10) + (PontosVida / 2) - 5;
Console.WriteLine($"\nSeu poder base então é {poderBase}⚔️");

if (poderBase % 2 == 0)
{
    Console.WriteLine($"Você ganhou um Bônus de ataque critico agora seu ataque é especial⚔️⚔️⚔️".ToUpper());
}

Console.WriteLine($"\n \n Agora que você sabe sua força, Você vai ver se ganha do {NomeDragão}");

if ((classeEscolhida == classeClérigo || classeEscolhida == classeMago || classeEscolhida == classeDruida) && (mana > 30 && nivelHerói >= 5))
{
    Console.WriteLine("Parabéns! Você usou sua magia e derrotou o dragão, você é um herói!!");
}
else if ((classeEscolhida == classeAnão || classeEscolhida == classeGuerreiro || classeEscolhida == classeElfo) && (PontosVida > 20 && poderBase > 50))
{
    Console.WriteLine("\n Parabéns! Sua força física derrotou o dragão, você é um herói!");
}
else
{
    // Se não passou em nenhum dos testes acima, tenta o suborno ou morre
    Console.WriteLine("Você não é forte o suficiente para lutar frente a frente...");

    if (Ouro >= 1000 || classeEscolhida == classeAnão)
    {
        Console.WriteLine("Mas você conseguiu subornar o dragão e sobreviveu!");
    }
    else
    {
        Console.WriteLine("Você não tem ouro nem força... virou churrasquinho de dragão! 🍖🐉");
    }
}

Console.WriteLine("clique qualquer tecla para sair");
Console.ReadLine();