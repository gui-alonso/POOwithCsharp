namespace IntroCSharp02.Exemplos;
public static class ExemploForeach01
{
    public static void Executar()
    {
        string[] nomes = { "Ana", "Carlos", "Maria", "João" };

        Console.WriteLine("Lista de nomes:");

        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }
}