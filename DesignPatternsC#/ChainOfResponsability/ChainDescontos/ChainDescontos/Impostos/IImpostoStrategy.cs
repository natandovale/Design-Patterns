using ChainDescontos.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainDescontos.Impostos
{
    public interface IImpostoStrategy
    {
        double Calcula(Orcamento orcamento);
    }
}
