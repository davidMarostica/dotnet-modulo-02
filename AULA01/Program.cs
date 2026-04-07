using System;
using System.Collections.Generic;
using dotnet_modulo_02.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "David";
pessoa1.Sobrenome = "Aparecido da Silva";

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Maria";
pessoa2.Sobrenome = "Aparecida Marostica";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Curso de Inglês";

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);

Console.WriteLine($"Quantidade de alunos: {cursoDeIngles.QuantidadeAlunos()}");

foreach (var aluno in cursoDeIngles.Alunos)
{
    Console.WriteLine($"{aluno.Nome} {aluno.Sobrenome}");
}
