using StrategyAplication.CalcularPagamentoDesconto.Interface;
using StrategyAplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyAplication.CalcularPagamento.PagamentoAVista
{
    class LivroRevistaFisicoJogoTabuleiroStrategy : ICalcularDescontoStrategy
    {
        public int CodigoTipoDesconto => 1;

        public double Calcula(List<Produto> produtos)
        {
            var total = 0.0;
            foreach (var produto in produtos)
            {
                total += produto.Preco;
            }
            return total * 0.3;
        }
    }
}
