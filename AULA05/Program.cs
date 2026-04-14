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

// Propriedade nullable para desconto

// string conteudo = File.ReadAllText("Arquivos/venda.json");
// List<Venda> vendasDesserializadas = JsonConvert.DeserializeObject<List<Venda>>(conteudo);

// foreach (Venda venda in vendasDesserializadas)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//     $"Preço: {venda.Preco}, Data: {venda.DataVenda}, Quantidade: {venda.Quantidade}," +
//     $"Data de Venda: {venda.DataVenda.ToString("dd/MM/yyyy")}, "+
//     $"Desconto: {(venda.Desconto.HasValue ? venda.Desconto.Value.ToString("C") : "Sem desconto")}, Total: {venda.Total.ToString("C")}"); 


// }




// Tipo Anônimo

// var vendaAnonima = new { Nome = "David", Idade = 30, Email = "david@example.com" };

// Console.WriteLine($"Nome: {vendaAnonima.Nome}"); 
// Console.WriteLine($"Idade: {vendaAnonima.Idade}");
// Console.WriteLine($"Email: {vendaAnonima.Email}");

// tipo coleção anônima
// {
//         string conteudo = File.ReadAllText("Arquivos/venda.json");

//         List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudo);

//         var vendasAnonimas = listaVendas.Select(v => new 
//         { 
//             v.Produto, 
//             v.Preco, 
//             v.Quantidade, 
//             Total = v.Total 
//         });

//         Console.WriteLine("-----Vendas Anônimas:---------"); 

//         foreach (var venda in vendasAnonimas)
//         {
//             Console.WriteLine(
//                 $"Produto: {venda.Produto}, Preço: {venda.Preco}, Quantidade: {venda.Quantidade}, Total: {venda.Total}"
//             );
//         }
//     }

// Dynamic  

dynamic variavelDinamica = 4;
Console.WriteLine($"Valor: {variavelDinamica}, Tipo: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = "texto";
Console.WriteLine($"Valor: {variavelDinamica}, Tipo: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = true;
Console.WriteLine($"Valor: {variavelDinamica}, Tipo: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");