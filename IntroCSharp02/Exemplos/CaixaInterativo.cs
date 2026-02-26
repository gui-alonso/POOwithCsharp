namespace IntroCSharp02.Exemplos;

public static class CaixaInterativo
{
    public static void Executar()
    {
        Console.WriteLine("--- PDV - Loja de Conveniência ---");

        // Solicitando o preço do produto
        Console.Write("Digite o valor do produto: R$ ");
        decimal preco = decimal.Parse(Console.ReadLine()!);

        // Solicitando o valor pago
        Console.Write("Valor pago pelo cliente: R$ ");
        decimal valorPago = decimal.Parse(Console.ReadLine()!);

        // Lógica simples de troco
        if (valorPago < preco)
        {
            decimal falta = preco - valorPago;
            Console.WriteLine($"Erro: Dinheiro insuficiente! Faltam R$ {falta:F2}");
        }
        else
        {
            decimal troco = valorPago - preco;
            Console.WriteLine($"Venda realizada com sucesso!");
            Console.WriteLine($"Troco a devolver: R$ {troco:F2}");
        }
    }
}