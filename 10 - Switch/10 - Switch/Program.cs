Console.Write("Escolha um número entre 1 e 12: ");
int numMes = int.Parse(Console.ReadLine());

switch (numMes)
{
    case 1:
        Console.WriteLine($"Você escolheu o mês de Janeiro, e a estação é Verão");
        break;
    case 2:
        Console.WriteLine($"Você escolheu o mês de Fevereiro, e a estação é Verão");
        break;
    case 3:
        Console.WriteLine($"Você escolheu o mês de Março, e a estação é Outono");
        break;
    case 4:
        Console.WriteLine($"Você escolheu o mês de Abril, e a estação é Outono");
        break;
    case 5:
        Console.WriteLine($"Você escolheu o mês de Maio, e a estação é Outono");
        break;
    case 6:
        Console.WriteLine($"Você escolheu o mês de Junho, e a estação é Inverno");
        break;
    case 7:
        Console.WriteLine($"Você escolheu o mês de Julho, e a estação é Inverno");
        break;
    case 8:
        Console.WriteLine($"Você escolheu o mês de Agosto, e a estação é Inverno");
        break;
    case 9:
        Console.WriteLine($"Você escolheu o mês de Setembro, e a estação é Primavera");
        break;
    case 10:
        Console.WriteLine($"Você escolheu o mês de Outubro, e a estação é Primavera");
        break;
    case 11:
        Console.WriteLine($"Você escolheu o mês de Novembro, e a estação é Primavera");
        break;
    case 12:
        Console.WriteLine($"Você escolheu o mês de Desembro, e a estação é Verão");
        break;
    default:
        Console.WriteLine("O número escolhido não é permitido");
        Console.WriteLine("Escolha um número entre 1 e 12");
        break;
}

Console.WriteLine("Clique uma tecla para encerrar");
Console.ReadKey();
