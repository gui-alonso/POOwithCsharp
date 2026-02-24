using System;

namespace IntroCSharp02.Exemplos
{
    public static class Exemplo02
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("ÍMPAR");
        }
    }
}