namespace IntroCSharp02.Exemplos;

public static class ExemploForeach03
{
    public static void Executar()
    {
        List<int> numeros = new List<int> { 5, 2 , 9, 1, 3, 8, 4, 7, 10 };

        Console.WriteLine("Lista de números pares:");

        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine(numero);
            }
        }
    }
}