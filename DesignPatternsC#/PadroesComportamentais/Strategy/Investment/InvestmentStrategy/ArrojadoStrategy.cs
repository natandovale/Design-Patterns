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
            var numeroSorteado = new Random().Next(100);
            if (numeroSorteado < 20)
                return valor * 0.05;
            if (numeroSorteado < 50)
                return valor * 0.03;

            return valor * 0.006;
        }
    }
}
