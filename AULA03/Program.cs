using System;
using System.Collections.Generic;
using AULA03.Models;



// (int, string, string, decimal) tupla = (1, "Olá", "Mundo", 100.50m);
// // ValueTuple<int, string, string, decimal> outroExemploTupla = (2, "Olá", "C#", 200.75m);
// // var outroExemploTupla2 = Tuple.Create(3, "Olá", "Programação", 300.25m);

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Número: {tupla.Item2}");
// Console.WriteLine($"Mensagem: {tupla.Item3}");
// Console.WriteLine($"Valor: {tupla.Item4}");

LeituraAquivo arquivo = new LeituraAquivo();
var (success, linhas, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
 
if (success)
{
    Console.WriteLine($"Quantidade de linhas: {quantidadeLinhas}");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Falha ao ler o arquivo.");
}