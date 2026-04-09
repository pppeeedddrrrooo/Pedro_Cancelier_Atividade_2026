// Importação
using System.Runtime.Serialization;
using System.Threading;

// Console para utilizar emoji
Console.OutputEncoding = System.Text.Encoding.UTF8;

bool jogarnovamente = true;
while (jogarnovamente)
{
    // texto inicial 1
    Console.WriteLine("Você é um mago \U0001f9d9‍♂️ convocado para a Arena dos Ancestrais 🏛️" +
        ", um evento anual que decide quem é o mestre mais forte.Você está aqui para provar seu domínio sobre os elementos" +
        " 🔥🌊🌱, sabendo que nenhum feitiço é invencívelsua magia pode vencer vários rivais, mas também possui fraquezas" +
        " contra outros  ⚡🛡️❄️.\r\nEscolha seu poder com responsabilidade 🔮 e lance sua magia para descobrir se ela" +
        " superará a do seu oponente ou se será anulada pela força superior dele! ✨⚔️);");
    Console.WriteLine("pressino ENTER para continuar");
    Console.ReadLine();

    Console.Clear();

    // preparação
    Console.WriteLine("Prepare-se para o duelo...");
    Thread.Sleep(2000);

    Console.Clear();



    //Texto Inicial
    Console.WriteLine("Escolha um feitiço " +
        "\r\n\r\n🔥 Bola de Fogo" +
        "\r\n\r\n🌊 Agua" +
        "\r\n\r\n🌱 Raizes da Terra" +
        "\r\n\r\n⚡ Raio" +
        "\r\n\r\n🛡 Escudo Arcano" +
        "\r\n\r\n❄ Gelo\n ");

    //Declarar Variável
    string JogadaPlayer = Console.ReadLine().ToLower();
    int BoladeFogo = 1, Agua = 2, RaízesdaTerra = 3, Raio = 4, EscudoArcano = 5, Gelo = 6;
    int JogadaCPU = 0;
    Random Aleatório = new Random();
    JogadaCPU = Aleatório.Next(1, 7);

    string FeiticoCPU = "";

    if (JogadaCPU == BoladeFogo) FeiticoCPU = "🔥 Bola de Fogo";
    if (JogadaCPU == Agua) FeiticoCPU = "🌊 Água";
    if (JogadaCPU == RaízesdaTerra) FeiticoCPU = "🌱 Raízes da Terra";
    if (JogadaCPU == Raio) FeiticoCPU = "⚡ Raio";
    if (JogadaCPU == EscudoArcano) FeiticoCPU = "🛡 Escudo Arcano";
    if (JogadaCPU == Gelo) FeiticoCPU = "❄ Gelo";

    Console.Clear();

    //simulação
    Console.WriteLine("Os magos levantam seus cajados...");
    Thread.Sleep(1500);

    Console.WriteLine("A energia mágica começa a se formar...");
    Thread.Sleep(1500);

    Console.WriteLine("Os feitiços são lançados!");
    Thread.Sleep(2000);


    Console.Clear();


    //Situações de jogo
    if (JogadaPlayer == "bola de fogo" && JogadaCPU == 3)
    {
        Console.WriteLine("O outro mago tentou te prender com raízes 🌱, mas seu fogo 🔥 as transformou em cinzas! Você venceu!");
    }
    if (JogadaPlayer == "bola de fogo" && JogadaCPU == 6)
    {
        Console.WriteLine("O oponente invocou uma tempestade de gelo ❄️, mas seu fogo 🔥 intenso derreteu tudo! Você venceu!");
    }
    if (JogadaPlayer == "bola de fogo" && JogadaCPU == 4)
    {
        Console.WriteLine("O inimigo disparou um raio ⚡, mas sua explosão de fogo 🔥 consumiu a energia dele! Você venceu!");
    }
    if (JogadaPlayer == "bola de fogo" && JogadaCPU == 2)
    {
        Console.WriteLine("Você lançou uma bola de fogo 🔥, mas o outro mago conjurou uma onda de água 🌊 e apagou seu fogo 🔥! Você perdeu!");

    }
    if (JogadaPlayer == "bola de fogo" && JogadaCPU == 5)
    {
        Console.WriteLine("Você atacou com fogo 🔥, mas o oponente ergueu um escudo arcano 🛡️ que refletiu o calor contra você! Você perdeu!");

    }
    if (JogadaPlayer == "agua" && JogadaCPU == 1)
    {
        Console.WriteLine("O outro mago disparou uma bola de fogo 🔥, mas sua onda de água 🌊 a sufocou completamente! Você venceu!");

    }
    if (JogadaPlayer == "agua" && JogadaCPU == 5)
    {
        Console.WriteLine("O inimigo se escondeu atrás de um escudo arcano 🛡️, mas sua onda de água 🌊 fluiu pelas frestas e o derrubou! Você venceu!");

    }
    if (JogadaPlayer == "agua" && JogadaCPU == 6)
    {
        Console.WriteLine("O oponente tentou te congelar com gelo ❄️, mas a força da sua onda de água 🌊 quebrou o gelo ❄️! Você venceu!");

    }
    if (JogadaPlayer == "agua" && JogadaCPU == 4)
    {
        Console.WriteLine("Você lançou um jato de onda de água 🌊, mas o outro mago disparou um raio ⚡ que te eletrocutou pela água 🌊! Você perdeu!");

    }
    if (JogadaPlayer == "agua" && JogadaCPU == 3)
    {
        Console.WriteLine("Você tentou afogar o inimigo com onda de água 🌊, mas o outro mago fez brotar raízes da terra 🌱 que sugaram sua energia! Você perdeu!");

    }
    if (JogadaPlayer == "raizes da terra" && JogadaCPU == 4)
    {
        Console.WriteLine("O outro mago lançou um raio ⚡, mas você usou as raízes da terra 🌱 para aterrar o choque e prendê-lo! Você venceu!");

    }
    if (JogadaPlayer == "raizes da terra" && JogadaCPU == 2)
    {
        Console.WriteLine("O oponente enviou uma onda de água 🌊, mas suas raízes da terra 🌱 absorveram a água 🌊 e ficaram gigantes! Você venceu!");

    }
    if (JogadaPlayer == "raizes da terra" && JogadaCPU == 5)
    {
        Console.WriteLine("O inimigo tentou se defender com um escudo arcano 🛡️, mas suas raízes da terra 🌱 brotaram do chão e o imobilizaram! Você venceu!");

    }
    if (JogadaPlayer == "raizes da terra" && JogadaCPU == 1)
    {
        Console.WriteLine("Você tentou prender o oponente com raízes da terra 🌱, mas o outro mago lançou fogo 🔥 que queimou sua magia! Você perdeu!");

    }
    if (JogadaPlayer == "raizes da terra" && JogadaCPU == 6)
    {
        Console.WriteLine("Você invocou raízes da terra 🌱, mas o outro mago usou gelo ❄️ para congelar suas plantas, quebrando-as! Você perdeu!");

    }
    if (JogadaPlayer == "raio" && JogadaCPU == 2)
    {
        Console.WriteLine("O outro mago lançou onda de água 🌊, mas seu raio ⚡ viajou pela torrente e o atingiu em cheio! Você venceu!");

    }
    if (JogadaPlayer == "raio" && JogadaCPU == 6)
    {
        Console.WriteLine("O inimigo criou uma barreira de gelo ❄️, mas seu raio ⚡ a estilhaçou como se fosse vidro! Você venceu!");

    }
    if (JogadaPlayer == "raio" && JogadaCPU == 3)
    {
        Console.WriteLine("Você disparou um raio ⚡, mas o outro mago usou raízes da terra 🌱 para desviar o choque e te pegou! Você perdeu!");

    }
    if (JogadaPlayer == "raio" && JogadaCPU == 5)
    {
        Console.WriteLine("Você lançou seu raio ⚡, mas o oponente usou um escudo arcano 🛡️ para devolver a eletricidade em você! Você perdeu!");

    }
    if (JogadaPlayer == "raio" && JogadaCPU == 1)
    {
        Console.WriteLine("Você atacou com raio ⚡, mas o outro mago criou uma explosão de fogo 🔥 que dissipou seu raio ⚡! Você perdeu!");

    }
    if (JogadaPlayer == "escudo arcano" && JogadaCPU == 1)
    {
        Console.WriteLine("O outro mago lançou fogo 🔥, mas seu escudo arcano 🛡️ repeliu as chamas sem esforço! Você venceu!");

    }
    if (JogadaPlayer == "escudo arcano" && JogadaCPU == 4)
    {
        Console.WriteLine("O oponente disparou um raio ⚡, mas seu escudo arcano 🛡️ agiu como um espelho e mandou o choque de volta! Você venceu!");

    }
    if (JogadaPlayer == "escudo arcano" && JogadaCPU == 3)
    {
        Console.WriteLine("Você ergueu seu escudo arcano 🛡️, mas o outro mago fez raízes da terra 🌱 surgirem do chão e te imobilizou! Você perdeu!");

    }
    if (JogadaPlayer == "escudo arcano" && JogadaCPU == 6)
    {
        Console.WriteLine("Você se protegeu com escudo arcano 🛡️, mas o outro mago lançou um gelo ❄️ extremo que quebrou sua magia! Você perdeu!");

    }
    if (JogadaPlayer == "escudo arcano" && JogadaCPU == 2)
    {
        Console.WriteLine("Você tentou bloquear com escudo arcano 🛡️, mas o outro mago usou a pressão de uma onda de água 🌊 para esmagar sua defesa! Você perdeu!");

    }
    if (JogadaPlayer == "gelo" && JogadaCPU == 3)
    {
        Console.WriteLine("O outro mago tentou usar raízes da terra 🌱, mas seu gelo ❄️ congelou a vida delas instantaneamente! Você venceu!");

    }
    if (JogadaPlayer == "gelo" && JogadaCPU == 6)
    {
        Console.WriteLine("O oponente se defendeu com escudo arcano 🛡️, mas seu gelo ❄️ cobriu o escudo 🛡️ até a barreira perder a força! Você venceu!");

    }
    if (JogadaPlayer == "gelo" && JogadaCPU == 2)
    {
        Console.WriteLine("O gelo ❄️ começa a rachar e se dissolve diante da força da água 🌊! Você perdeu!");

    }
    if (JogadaPlayer == "gelo" && JogadaCPU == 1)
    {
        Console.WriteLine("Você tentou congelar com gelo ❄️, mas o outro mago lançou fogo 🔥 que vaporizou seu ataque! Você perdeu!");

    }
    if (JogadaPlayer == "gelo" && JogadaCPU == 4)
    {
        Console.WriteLine("Você criou uma tempestade de gelo ❄️, mas o outro mago disparou um raio ⚡ que atravessou o frio e te atingiu! Você perdeu!");

    }

    // Situação de empate
    if (JogadaPlayer == "bola de fogo" && JogadaCPU == 1)
    {
        Console.WriteLine("As chamas 🔥 colidem e explodem no ar! Empate!");

    }
    // Situação de empate
    if (JogadaPlayer == "agua" && JogadaCPU == 2)
    {
        Console.WriteLine("As ondas de agua 🌊 se chocam e se espalham pela arena! Empate!");

    }
    if (JogadaPlayer == "gelo" && JogadaCPU == 6)
    {
        Console.WriteLine("Cristais de gelo❄ ❄️ se quebram no impacto! Empate!");

    }
    if (JogadaPlayer == "raio" && JogadaCPU == 4)

    {
        Console.WriteLine("Relâmpagos ⚡ se cruzam no céu da arena! Empate!");

    }
    if (JogadaPlayer == "raizes da terra" && JogadaCPU == 3)
    {
        Console.WriteLine("A terra treme 🌱 e as forças se anulam — Empate!");

    }
    if (JogadaPlayer == "escudo arcano" && JogadaCPU == 5)
    {
        Console.WriteLine("As barreiras 🛡 mágicas brilham e resistem! Empate!");

    }



    //Final de tudo
    Console.WriteLine("pressino ENTER para continuar");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Deseja jogar novamente?(s/n)");
    string resposta = Console.ReadLine().ToLower();
    if (resposta != "s")
    {
        jogarnovamente = false;

    }
}
Console.WriteLine("obrigado por jogar");
