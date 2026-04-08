using AULA02.Models;
using System.Globalization;
using System.Collections.Generic;



// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Diretório não encontrado: {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Erro de leitura do arquivo: {ex.Message}");
// }

// finally
// {
//     Console.WriteLine("Programa finalizado.");
// }



// new ExemploExcecao().Metodo1();


// Fila - FIFO (First In, First Out)
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(1);
// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);
// fila.Enqueue(5);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento:{fila.Dequeue()}");

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


//pilha - LIFO (Last In, First Out)

// Stack<int> pilha = new Stack<int>();
// pilha.Push(1);
// pilha.Push(2);
// pilha.Push(3);
// pilha.Push(4);
// pilha.Push(5);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento:{pilha.Pop()}");

// pilha.Push(20);
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }



Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

Console.WriteLine("------------------------------");

estados.Remove("RJ");
estados["SP"] = "São Paulo - Atualizado";
{
    foreach (KeyValuePair<string, string> item in estados)
    {
        Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
    }
}

string chave = "MG";
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor da chave {chave}: {estados[chave]}");
}
else
{
    Console.WriteLine($"Chave {chave} não encontrada.");
}   