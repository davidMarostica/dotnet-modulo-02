using System;
using AULA05.Models;
using System.Collections.Generic;
using Newtonsoft.Json;



// bool? desejaReceberEmnail = true;
// if (desejaReceberEmnail.HasValue)
// {
//     if (desejaReceberEmnail.Value && desejaReceberEmnail.Value == true)
//     {
//         Console.WriteLine("O usuário deseja receber email.");
//     }
//     else
//     {
//         Console.WriteLine("O usuário não deseja receber email.");
//     }
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu sobre receber email.");
//}


string conteudo = File.ReadAllText("Arquivos/venda.json");
List<Venda> vendasDesserializadas = JsonConvert.DeserializeObject<List<Venda>>(conteudo);

foreach (Venda venda in vendasDesserializadas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
    $"Preço: {venda.Preco}, Data: {venda.DataVenda}, Quantidade: {venda.Quantidade}," +
    $"Data de Venda: {venda.DataVenda.ToString("dd/MM/yyyy")}, "+
    $"Desconto: {(venda.Desconto.HasValue ? venda.Desconto.Value.ToString("C") : "Sem desconto")}, Total: {venda.Total.ToString("C")}"); 


}