using StrategyAplication.CalcularPagamentoDesconto.Interface;
using StrategyAplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyAplication.Business
{
    public class CalculadorDesconto
    {
        public List<ICalcularDescontoStrategy> _strategies;

        public CalculadorDesconto(List<ICalcularDescontoStrategy> strategies)
        {
            _strategies = strategies;
        }

        public void RealizaCalculo(List<Produto> produtos, int tipoDesconto)
        {
            var res = GetTypeStrategy(_strategies, tipoDesconto).Calcula(produtos);
            Console.WriteLine(res);
        }

        private ICalcularDescontoStrategy GetTypeStrategy(List<ICalcularDescontoStrategy>  _strategies , int tipoDesconto)
        {
            var strategy = _strategies.FirstOrDefault(s => s.TipoDesconto == tipoDesconto);
            return strategy;
        }
    }
}
