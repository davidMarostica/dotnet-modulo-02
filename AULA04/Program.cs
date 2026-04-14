using System.Globalization;
using Models;
using Newtonsoft.Json;

List<Venda> listaVendas = new List<Venda>();

Venda venda1 = new Venda(1, "Notebook", 3500.00m, 2);
Venda venda2 = new Venda(2, "Mouse", 100.00m, 5);
Venda venda3 = new Venda(3, "Teclado", 200.00m, 3);

listaVendas.Add(venda1);
listaVendas.Add(venda2);
listaVendas.Add(venda3);



string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
Console.WriteLine("Venda serializada:");
Console.WriteLine(serializado);

File.WriteAllText("Arquivos/venda.json", serializado);
