using System;

namespace IntroCSharp02
{
    public class Aula01
    {
        public static void Executar()
        {
            Console.WriteLine("Aula 01 - Introdução ao C#");

            //Console.WriteLine("Hello World!");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Meu nome é: " + nome + "e tenho " + idade + " anos.");
        }
    }
}