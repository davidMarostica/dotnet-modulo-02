using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, int quantidade, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            Quantidade = quantidade;
            DataVenda = dataVenda;
        }
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal Total => Preco * Quantidade;
        
    }
    
}