using Investment.Business;
using Investment.InvestmentStrategy;
using Investment.Model;
using System;
using System.Collections.Generic;

namespace Investment
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta { Saldo = 40};

            IInvestmentStrategy investimentoModerado = new ModeradoStrategy();
            IInvestmentStrategy investimentoConservador = new ConservadorStrategy();
            IInvestmentStrategy investimentoArrojado = new ArrojadoStrategy();
            List<IInvestmentStrategy> descontoStrategies = new List<IInvestmentStrategy>
            {
                investimentoModerado,
                investimentoConservador,
                investimentoArrojado
            };

            var calc = new RealizadorDeInvestimentos(descontoStrategies);
            calc.RealizaCalculo(conta, 3);
        }
    }
}
