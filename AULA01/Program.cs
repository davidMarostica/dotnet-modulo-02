using System;
using dotnet_modulo_02.Models;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "David";
        pessoa1.Sobrenome = "Aparecido da Silva";

        Pessoa pessoa2 = new Pessoa();
        pessoa2.Nome = "Maria";
        pessoa2.Sobrenome = "Aparecida Marostica";

        Curso cursoDeIngles = new Curso();
        cursoDeIngles.Nome = "Inglês";

        cursoDeIngles.AdicionarAluno(pessoa1);
        cursoDeIngles.AdicionarAluno(pessoa2);


        cursoDeIngles.ListarAlunos();
    }
}
