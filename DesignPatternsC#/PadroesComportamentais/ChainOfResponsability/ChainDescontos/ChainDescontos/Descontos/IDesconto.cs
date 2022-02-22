using ChainDescontos.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainDescontos.Descontos
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }   
        double Desconta(Orcamento orcamento);
    }
}
