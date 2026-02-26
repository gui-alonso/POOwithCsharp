namespace IntroCSharp02.Exemplos;

public static class CalculoSimples
{
    public static void Executar()
    {
        int resultado = Somar(10, 20);
        Console.WriteLine($"O resultado da soma de 10 + 20 é: {resultado}");
    }

    // Uma função bem simples que apenas soma dois números
    static int Somar(int a, int b)
    {
        return a + b;
    }
}