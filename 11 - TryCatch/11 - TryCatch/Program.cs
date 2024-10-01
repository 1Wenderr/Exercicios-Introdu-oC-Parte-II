using System.Globalization;
try
{
    Console.Write("Digite o primeiro número: ");
    double n1;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out n1))
    {
        Console.WriteLine("\nErro: Por favor digite um número valído");
        Console.Write("Digite o primeiro número: ");
    }

    Console.Write("Digite o segundo número: ");
    double n2;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out n2))
    {
        Console.WriteLine("\nErro: Por favor digite um número valído");
        Console.Write("Digite o segundo número: ");
    }

    double resultado = n1 + n2;
    Console.WriteLine($"\nO resultado da soma é: {resultado}");
}

catch (FormatException)
{
    Console.WriteLine("Erro: Por favor, digite números válidos");
}
Console.WriteLine("\nAperte uma tecla para encerrar");
Console.ReadKey();
