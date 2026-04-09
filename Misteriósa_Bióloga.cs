Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Digite um número inteiro para catalogar os protozoários🧬🧫: " +
    "\nDigite 1 para catalogar euglenófitas. \nDigite 2 para catalogar clórofitas. \nDigite 3 para catalogar bacilariófitas." +
    "\nDigite 4 para catalogar rodófitas. \nDigite 5 para catalogar pirrófitas. \nDigite 6 para catalogar amebas." +
    " \nDigite 7 para catalogar toxoplasma. \nDigite 8 para catalogar filariose. \nDigite 9 para catalogar tripomastigotas. ");
string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        Console.WriteLine("Você catalogou euglenófitas.");
        break;
    case "2":
        Console.WriteLine("Você catalogou clorófitas.");
        break;
    case "3":
        Console.WriteLine("Você catalogou bacilariófitas.");
        break;
    case "4":
        Console.WriteLine("Você catalogou rodófitas.");
        break;
    case "5":
        Console.WriteLine("Você catalogou pirrófitas.");
        break;
    case "6":
        Console.WriteLine("Você catalogou amebas.");
        break;
    case "7":
        Console.WriteLine("Você catalogou toxoplasma.");
        break;
    case "8":
        Console.WriteLine("Você catalogou filariose.");
        break;
    case "9":
        Console.WriteLine("Você catalogou tripomastigotas.");
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}







