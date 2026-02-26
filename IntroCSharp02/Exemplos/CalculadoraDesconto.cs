using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp02.Exemplos
{
    public static class  CalculadoraDesconto
    {
        public static void Executar()
        {
            Console.WriteLine("--- Sistema de Checkout ---");
            Console.Write("Digite o valor da compra: R$ ");
            double valor = double.Parse(Console.ReadLine()!);

            // Uso de Condicional Composta
            if (valor >= 500)
            {
                double desconto = valor * 0.15;
                Console.WriteLine($"VIP: Desconto de 15% aplicado! Final: R$ {valor - desconto}");
            }
            else if (valor >= 200)
            {
                Console.WriteLine($"Comum: Desconto de 5% aplicado! Final: R$ {valor * 0.95}");
            }
            else
            {
                Console.WriteLine("Valor mínimo para desconto não atingido.");
            }
        }
    }
}
