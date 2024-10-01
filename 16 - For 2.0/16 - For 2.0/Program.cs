int n1, resul;
Console.Write("Informe o número: ");
n1 = int.Parse(Console.ReadLine());

resul = n1;
for (int i = n1 - 1; i >= 1; i--)
{
    Console.WriteLine($"\n{resul} x {i}");

    resul = resul * i;

    Console.WriteLine("  ");
}
Console.WriteLine($"\nFatorial de {n1} é {resul} ");

Console.WriteLine("\nAperte uma tecla para encerrar");
Console.ReadKey();