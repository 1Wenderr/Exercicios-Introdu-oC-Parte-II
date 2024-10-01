int nota;
Console.Write("Informe a sua nota: ");
int.TryParse(Console.ReadLine(), out nota);

if (nota >= 90 && nota <= 100)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Sua nota é A");
    Console.ResetColor();
}
else if (nota >= 80 && nota <= 89)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Sua nota é B");
    Console.ResetColor();
}

else if (nota >= 70 && nota <= 79)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Sua nota é C");
    Console.ResetColor();
}
else if (nota >= 60 && nota <= 69)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Sua nota é D");
    Console.ResetColor();
}
else if (nota >= 101)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Nota invalida");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Sua nota é F");
    Console.ResetColor();
}
Console.WriteLine("Programa encerrado!");
Console.ReadKey();