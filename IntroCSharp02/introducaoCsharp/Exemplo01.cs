using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp02.introducaoCsharp
{
    public class Exemplo01
    {
        public static void Executar()
        {
            Console.WriteLine("=========== EXEMPLO 01 ====================");
            Console.WriteLine("Olá, seja bem-vindo ao curso de C#!");
            Console.WriteLine("============================================");

            /**
             * coverter int para string
             * int.Parse("123") -> converte string para int
             * converter double para string
             * double.Parse("3.14") -> converte string para double
             */
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Você tem " + idade + " anos");
        }
    }
}
