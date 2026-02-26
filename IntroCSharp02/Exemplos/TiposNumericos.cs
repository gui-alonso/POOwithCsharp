namespace IntroCSharp02.Exemplos;

public static class TiposNumericos
{
    public static void Executar()
    {
        // O float EXIGE o 'f' no final
        float piSimples = 3.14159265f;

        // O double é o padrão, não precisa de sufixo
        double piPreciso = 3.1415926535897931;

        Console.WriteLine($"Float (menos preciso): {piSimples}");
        Console.WriteLine($"Double (mais preciso): {piPreciso}");
    }
}