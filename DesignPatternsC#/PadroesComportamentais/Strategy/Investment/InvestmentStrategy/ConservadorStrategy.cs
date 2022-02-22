using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.InvestmentStrategy
{
    public class ConservadorStrategy : IInvestmentStrategy
    {
        public int CodigoTipoPerfil => 1;

        //Retorna 0.8% do valor investido
        public double Calcula(double valor)
        {
            return valor * 0.008;
        }
    }
}
