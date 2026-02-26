namespace IntroCSharp02.Exemplos;

public static class Contagem
{
    public static void Executar()
    {
        Console.WriteLine("Contagem regressiva para o lançamento:");

        // Exemplo clássico de decremento
        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine($"Faltam {i} segundos...");
        }

        Console.WriteLine("DECOLAR! 🚀");
    }
}