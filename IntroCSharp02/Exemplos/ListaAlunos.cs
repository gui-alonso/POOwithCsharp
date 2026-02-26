namespace IntroCSharp02.Exemplos;

public static class ListaAlunos
{
    public static void Executar()
    {
        // Criando um array com 3 nomes
        string[] alunos = ["Ana", "Bruno", "Carla"];

        Console.WriteLine("Lista de alunos no sistema:");

        // Acessando manualmente para mostrar que começa no ZERO
        Console.WriteLine($"Primeiro aluno: {alunos[0]}");
        Console.WriteLine($"Segundo aluno: {alunos[1]}");
        Console.WriteLine($"Terceiro aluno: {alunos[2]}");
    }
}