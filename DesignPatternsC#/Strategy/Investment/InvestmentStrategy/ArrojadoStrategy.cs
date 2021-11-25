using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.InvestmentStrategy
{
    public class ArrojadoStrategy : IInvestmentStrategy
    {
        public int CodigoTipoPerfil => 3;

        //tem 20% de chances de retornar 5%, 30% de chances de retornar 3%, e 50% de chances de retornar 0.6%
        public double Calcula(double valor)
        {
            bool VintePorCentoDeChance = new Random().Next(101) <= 20;
            if (VintePorCentoDeChance)
                return valor * 0.05;

            bool TrintaPorCentoDeChance = new Random().Next(101) <= 30;
            if (TrintaPorCentoDeChance)
                return valor * 0.03;

            bool CiquentaPorCentoDeChance = new Random().Next(101) <= 50;
            if (CiquentaPorCentoDeChance)
                return valor * 0.006;

            return 0;
        }
    }
}
