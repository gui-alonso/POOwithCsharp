namespace IntroCSharp02.Exemplos;

public static class ValidacaoSimples
{
    public static void Executar()
    {
        int nota;

        do
        {
            Console.Write("Digite uma nota entre 0 e 10: ");
            nota = int.Parse(Console.ReadLine()!);

            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("Nota inválida! Tente novamente.");
            }

        } while (nota < 0 || nota > 10);

        Console.WriteLine($"Nota {nota} registrada com sucesso!");
    }
}