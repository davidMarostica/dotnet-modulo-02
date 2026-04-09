using System;

namespace AULA03.Models
{
    public class Pessoa
    {
        private string _nome;
        private string _sobrenome;
        private int _idade;

        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome não pode ser vazio.");
                _nome = value;
            }
        }
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }


        public string Sobrenome
        {
            get => _sobrenome.ToUpper();
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O sobrenome não pode ser vazio.");
                _sobrenome = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                    throw new ArgumentException("A idade não pode ser negativa.");
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }

               public void Deconstruct(out string nome, out string sobrenome, out int idade)
        {
            nome = Nome;
            sobrenome = Sobrenome;
            idade = Idade;
        }
    }
}
