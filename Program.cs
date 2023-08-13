using System;

var opcao = string.Empty;
do
{
    MainMenu();
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            OperacaoSoma();
            break;
        case "2":
            OperacaoSub();
            break;
        case "3":
            OperacaoMult();
            break;
        case "4":
            OperacaoDiv();
            break;
        case "5":
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Opção inválida. Por favor, selecione um número de 1 a 5.");
            Console.WriteLine();
            break;
    }

} while (opcao != "5");

void MainMenu()
{
    Console.WriteLine("***CALCULADORA***");
    Console.WriteLine("Selecione uma das operações abaixo:");
    Console.WriteLine("1) Soma");
    Console.WriteLine("2) Subtração");
    Console.WriteLine("3) Multiplicação");
    Console.WriteLine("4) Divisão");
    Console.WriteLine("5) Sair do programa");
}

void OperacaoSoma()
{
    Console.WriteLine();
    Console.WriteLine("A opção selecionada foi Soma!");
    Console.Write("Digite o segundo número: ");
    String num1 = Console.ReadLine();
    Console.Write("Digite o primeiro número: ");
    String num2 = Console.ReadLine();
    var a = float.Parse(num1);
    var b = float.Parse(num2);
    Console.WriteLine("A soma de " + a + " + " + b + " é igual a: " + (a+b));
    Console.WriteLine();
}

void OperacaoSub()
{
    Console.WriteLine();
    Console.WriteLine("A opção selecionada foi Subtração!");
    Console.Write("Digite o segundo número: ");
    String num1 = Console.ReadLine();
    Console.Write("Digite o primeiro número: ");
    String num2 = Console.ReadLine();
    var a = float.Parse(num1);
    var b = float.Parse(num2);
    Console.WriteLine("A subtração de " + a + " - " + b + " é igual a: " + (a-b));
    Console.WriteLine();
}

void OperacaoMult()
{
    Console.WriteLine();
    Console.WriteLine("A opção selecionada foi Multiplicação!");
    Console.Write("Digite o segundo número: ");
    String num1 = Console.ReadLine();
    Console.Write("Digite o primeiro número: ");
    String num2 = Console.ReadLine();
    var a = float.Parse(num1);
    var b = float.Parse(num2);
    Console.WriteLine("A multiplicação de " + a + " por " + b + " é igual a: " + (a*b));
    Console.WriteLine();
}

void OperacaoDiv()
{
    Console.WriteLine();
    Console.WriteLine("A opção selecionada foi Divisão!");
    Console.Write("Digite o segundo número: ");
    String num1 = Console.ReadLine();
    Console.Write("Digite o primeiro número: ");
    String num2 = Console.ReadLine();
    var a = float.Parse(num1);
    var b = float.Parse(num2);
    Console.WriteLine("A divisão de " + a + " por " + b + " é igual a: " + (a/b) + " e tem resto igual a: " + (a%b));
    Console.WriteLine();
}