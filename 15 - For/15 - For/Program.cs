Console.Write("Insira um número: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Tabuaba do {n1}");

for (int i = 0; i <= 10 ; i++)
{
    Console.WriteLine($"{i} x {n1} = {i * n1} ");
}
Console.Write("\nAperte uma tecla para encerrar");
Console.ReadKey();