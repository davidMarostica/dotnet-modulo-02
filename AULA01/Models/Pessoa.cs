using System;

namespace dotnet_modulo_02.Models
{
    public class Pessoa
    {
        // Campos privados
        private string _nome;
        private int _idade;

        // Propriedade Nome
        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _nome = value;
            }
        }
         public string Sobrenome { get; set; }
        public string  NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        // Propriedade Idade
        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa.");
                }
                else
                {
                    _idade = value;
                }
            }
        }

        // Método Apresentar
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}
