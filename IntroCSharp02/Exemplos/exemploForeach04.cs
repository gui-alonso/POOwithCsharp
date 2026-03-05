namespace IntroCSharp02.Exemplos;

public static class ExemploForeach04
{
    public static void Executar()
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Digite 5 números:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Número " + i + ": ");
            int numero = int.Parse(Console.ReadLine()!);

            numeros.Add(numero);
        }

        Console.WriteLine("\nNúmeros pares digitados:");

        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine(numero);
            }
        }
    }
}