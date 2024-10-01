Console.Write("Digite um número positivo: ");
int numero = int.Parse(Console.ReadLine());


Console.WriteLine($"Números de 0 até {numero}");
for (int i = 1; i <= numero; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nAperte uma tecla para encerrar");
Console.ReadKey();
