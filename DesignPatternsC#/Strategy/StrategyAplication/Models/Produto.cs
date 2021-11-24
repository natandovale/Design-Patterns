using StrategyAplication.Models.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyAplication.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public TipoProduto Codigo { get; set; }
    }
}
