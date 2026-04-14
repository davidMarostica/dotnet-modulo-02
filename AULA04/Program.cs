using System.Globalization;
using AULA04.Models;
using Newtonsoft.Json;

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda venda1 = new Venda(1, "Notebook", 3500.00m, 2, dataAtual);
// Venda venda2 = new Venda(2, "Mouse", 100.00m, 5, dataAtual);
// Venda venda3 = new Venda(3, "Teclado", 200.00m, 3, dataAtual);

// listaVendas.Add(venda1);
// listaVendas.Add(venda2);
// listaVendas.Add(venda3);



// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// Console.WriteLine("Venda serializada:");
// Console.WriteLine(serializado);

// File.WriteAllText("Arquivos/venda.json", serializado);

string conteudo = File.ReadAllText("Arquivos/venda.json");
List<Venda> vendasDesserializadas = JsonConvert.DeserializeObject<List<Venda>>(conteudo);

foreach (Venda venda in vendasDesserializadas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
    $"Preço: {venda.Preco}, Data: {venda.DataVenda}, Quantidade: {venda.Quantidade}," +
    $"Data de Venda: {venda.DataVenda.ToString("dd/MM/yyyy")}, Total: {venda.Total}");
}