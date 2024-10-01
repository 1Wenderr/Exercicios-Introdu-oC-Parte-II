int numSecreto = 7;

do
{
    Console.Write("\nDigite um número de 0 a 20: ");
    numSecreto = int.Parse(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nVocê errou o número secreto");
    Console.ResetColor();   
}
while (numSecreto != 7);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nParabéns!! Você acertou o número secreto");
Console.ResetColor();

Console.WriteLine("\nPrograma encerrado.");
Console.ReadKey();