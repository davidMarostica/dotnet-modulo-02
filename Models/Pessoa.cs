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
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}
