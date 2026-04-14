using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AULA04.Models
{
   public class Venda
{
    public int Id { get; set; }
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
    public DateTime DataVenda { get; set; }

    // Propriedade calculada
    public decimal Total
    {
        get { return Preco * Quantidade; }
    }
}

}

        