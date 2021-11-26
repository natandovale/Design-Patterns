using StrategyAplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyAplication.CalcularPagamentoDesconto.Interface
{
    public interface ICalcularDescontoStrategy
    {
        int CodigoTipoDesconto { get; }
        double Calcula(List<Produto> produtos);
    }
}
