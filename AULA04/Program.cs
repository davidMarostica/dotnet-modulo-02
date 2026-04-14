using System.Globalization;
using Models;
using Newtonsoft.Json;

Venda venda1 = new Venda(1, "Notebook", 3500.00m, 2);

string serializado = JsonConvert.SerializeObject(venda1, Formatting.Indented);
Console.WriteLine("Venda serializada:");
Console.WriteLine(serializado);

File.WriteAllText("Arquivos/venda.json", serializado);
