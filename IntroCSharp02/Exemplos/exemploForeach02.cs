namespace IntroCSharp02.Exemplos;

public static class ExemploForeach02
{
    public static void Executar()
    {
        List<int> numeros = new List<int> { 10, 20, 30, 40 };

        Console.WriteLine("Lista de números:");

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}