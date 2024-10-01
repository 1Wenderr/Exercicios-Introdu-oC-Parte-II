string[] vetDiaSemana = new string[]
{
    "Segunda-Feira", 
    "Terça-Feira",   
    "Quarta-Feira",  
    "Quinta-Feira",  
    "Sexta-Feira",   
    "Sábado",       
    "Domingo"        
};

string[] diaTarefa = new string[7];

for (int i = 0; i < vetDiaSemana.Length; i++)
{
    Console.Write($"Digite a tarefa para a casa {diaTarefa[i]}: ");
    diaTarefa[i] = Console.ReadLine();
}

Console.WriteLine("\nTarefas da semana:");
for (int i = 0; i < vetDiaSemana.Length; i++)
{

    Console.WriteLine($"{vetDiaSemana[i]}: {diaTarefa[i]}");

}

Console.ReadKey();
