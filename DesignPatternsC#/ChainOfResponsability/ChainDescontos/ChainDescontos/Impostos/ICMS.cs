using ChainDescontos.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainDescontos.Impostos
{
    public class ICMS : IImpostoStrategy
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.5;
        }
    }
}
