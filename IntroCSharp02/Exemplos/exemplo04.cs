using System;

namespace IntroCSharp02.Exemplos
{
    public static class ExemploCondicional02
    {
        public static void Executar()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("====== CALCULADORA SIMPLES COM MENU =======");
            Console.WriteLine("===========================================");
            Console.Write("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Resultado: " + (n1 + n2));
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Resultado: " + (n1 - n2));
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Resultado: " + (n1 * n2));
            }
            else if (opcao == 4)
            {
                if (n2 != 0)
                    Console.WriteLine("Resultado: " + (n1 / n2));
                else
                    Console.WriteLine("Não é possível dividir por zero!");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }
}