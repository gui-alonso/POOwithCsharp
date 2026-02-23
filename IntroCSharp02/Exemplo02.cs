using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleroCSharp02
{
    public class Exemplo02
    {
        public static void Executar()
        {
            Console.Write("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            double soma = n1 + n2;
            double sub = n1 - n2;
            double mult = n1 * n2;
            double div = n1 / n2;

            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Subtração: " + sub);
            Console.WriteLine("Multiplicação: " + mult);
            Console.WriteLine("Divisão: " + div);
        }
    }
}
