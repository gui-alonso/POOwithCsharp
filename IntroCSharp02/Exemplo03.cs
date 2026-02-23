using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleroCSharp02
{
    public class Exemplo03
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
            //double div = n1 / n2;

            if (n2 != 0)
            {
                double div = n1 / n2;
                Console.WriteLine("Divisão "+ div);
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }

            if (n1 > n2)
            {
                Console.WriteLine("O primeiro número é mior.");
            }
            else if (n2 > n1)
            {
                Console.WriteLine("O segundo número é maior.");
            }
            else
            {
                Console.WriteLine("Os dois números são iguais.");
            }
        }
    }
}
