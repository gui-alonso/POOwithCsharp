using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp02.introducaoCsharp
{
    public class Aula02
    {
        public static void Executar()
        {
            Console.WriteLine("Aula 02 - Variáveis e Tipos de Dados");
            // Variáveis
            int idade = 30;
            double altura = 1.75;
            string nome = "João";
            bool isEstudante = true;
            // Exibindo os valores
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"É estudante? {isEstudante}");
        }
    }
}
