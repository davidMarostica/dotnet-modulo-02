using System;
using AULA03.Models;



// (int, string, string, decimal) tupla = (1, "Olá", "Mundo", 100.50m);
// // ValueTuple<int, string, string, decimal> outroExemploTupla = (2, "Olá", "C#", 200.75m);
// // var outroExemploTupla2 = Tuple.Create(3, "Olá", "Programação", 300.25m);

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Número: {tupla.Item2}");
// Console.WriteLine($"Mensagem: {tupla.Item3}");
// Console.WriteLine($"Valor: {tupla.Item4}");

// LeituraAquivo arquivo = new LeituraAquivo();
// var (success, linhas, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (success)
// {
//     Console.WriteLine($"Quantidade de linhas: {quantidadeLinhas}");
//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Falha ao ler o arquivo.");
// }



//   class Program
// {
//     static void Main()
//     {
//         // Criando uma instância com o construtor
//         Pessoa pessoa1 = new Pessoa("david", "aparecido da silva", 30);

//         // Usando o desconstrutor para extrair valores
//         (string nome, string sobrenome, int idade) = pessoa1;

//         Console.WriteLine($"Nome: {nome}");
//         Console.WriteLine($"Sobrenome: {sobrenome}");
//         Console.WriteLine($"Idade: {idade}");

//         // Usando o método Apresentar
//         pessoa1.Apresentar();
//     }
// }

int numero = 11;
bool ehPar = numero % 2 == 0;

// if ternário
ehPar = numero % 2 == 0;

Console.WriteLine(ehPar ? $" O número {numero} é par." : $" O número {numero} é ímpar.");

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"{numero} é par.");
// }
// else
// {
//     Console.WriteLine($"{numero} é ímpar.");
// }