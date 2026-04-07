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

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}
