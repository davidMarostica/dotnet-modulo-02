using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AULA05.Models
{
    public class Venda
    {
       
            public int Id { get; set; }
            public string Produto { get; set; }
            public decimal Preco { get; set; }
            public int Quantidade { get; set; }
            public DateTime DataVenda { get; set; }
            public decimal? Desconto { get; set; } // Propriedade nullable para desconto


            // Propriedade calculada
            public decimal Total
            {
                get { return Preco * Quantidade - (Desconto ?? 0); }
            }
        }

    }
