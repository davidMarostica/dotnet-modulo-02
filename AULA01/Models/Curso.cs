using System;
using System.Collections.Generic;

namespace dotnet_modulo_02.Models
{
    public class Curso
    {
        // propriedades
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>();

        // métodos
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QuantidadeAlunos()
        {
            return Alunos.Count;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            bool removido = Alunos.Remove(aluno);
            if (removido)
            {
                Console.WriteLine($"{aluno.NomeCompleto} foi removido do curso de {Nome}.");
            }
            return removido;
        }

        public void ListarAlunos()
        {   
            Console.WriteLine($"Alunos do curso de: {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"N⁰ {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }

            Console.WriteLine($"Total de alunos: {Alunos.Count}");
        }
    }
}