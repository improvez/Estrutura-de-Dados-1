using System;
using System.Collections.Generic;


Dictionary<string, string> produtos = new Dictionary<string, string>
{
    { "123456789012", "A1" }, { "987654321098", "A1" }, { "111122223333", "A1" }, { "444455556666", "A1" }, { "777788889999", "A1" },
    { "222233334444", "B2" }, { "555566667777", "B2" }, { "888899990000", "B2" }, { "333344445555", "B2" }, { "666677778888", "B2" },
    { "999900001111", "C3" }, { "444466668888", "C3" }, { "222244446666", "C3" }, { "666688880000", "C3" }, { "111133335555", "C3" },
    { "000011112222", "A2" }, { "333355557777", "A2" }, { "888800002222", "A2" }, { "555577779999", "A2" }, { "777799991111", "A2" }
};

while (true)
{
    try
    {
        Console.WriteLine("Digite o código de barras do produto ou 'sair' para encerrar:");
        string codigoProduto = Console.ReadLine();
        if (codigoProduto.ToLower() == "sair")
        {
            break;
        }
        if (produtos.ContainsKey(codigoProduto))
        {
            string prateleira = produtos[codigoProduto];
            Console.WriteLine($"O produto está localizado na prateleira: {prateleira}");
        }
        else
        {
            Console.WriteLine("Código de barras não encontrado. Verifique se digitou corretamente.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    }
}