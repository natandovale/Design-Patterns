using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.InvestmentStrategy
{
    public interface IInvestmentStrategy
    {
        int CodigoTipoPerfil { get; }
        double Calcula(double valor);
    }
}
