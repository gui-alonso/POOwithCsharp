using System;

namespace IntroCSharp02.Exemplos
{
    public static class Exemplo01
    {
        public static void Executar()
        {
            Console.Write("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: " + (n1 + n2));
        }
    }
}