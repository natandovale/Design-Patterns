using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.InvestmentStrategy
{
    public class ModeradoStrategy : IInvestmentStrategy
    {
        public int CodigoTipoPerfil => 2;

        //tem 50% de chances de retornar 2.5%, e 50% de chances de retornar 0.7%
        public double Calcula(double valor)
        {
            //Verificar se a chance é maior que 50%
            bool chanceMaiorQueCiquenta = new Random().Next(101) > 50;
            if (chanceMaiorQueCiquenta)
                return valor * 0.025;
            return valor * 0.007;
        }
    }
}
