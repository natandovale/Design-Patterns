using StrategyAplication.CalcularPagamentoDesconto.Interface;
using StrategyAplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyAplication.CalcularPagamentoDesconto.PagamentoAVista
{
    class LivroRevistaDigitalStrategy : ICalcularDescontoStrategy
    {
        public int TipoDesconto => 2;

        public double Calcula(List<Produto> produtos)
        {
            var total = 0.0;
            foreach (var produto in produtos)
            {
                produto.Preco += total;
            }
            return total * 0.15;
        }
    }
}
