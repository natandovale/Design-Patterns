using Investment.InvestmentStrategy;
using Investment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Investment.Business
{
    public class RealizadorDeInvestimentos
    {
        public List<IInvestmentStrategy> _strategies;

        public RealizadorDeInvestimentos(List<IInvestmentStrategy> strategies)
        {
            _strategies = strategies;
        }

        public void RealizaCalculo(Conta conta, int tipoDesconto)
        {
            var valorInvestimento = GetTypeStrategy(_strategies, tipoDesconto).Calcula(conta.Saldo);
            conta.AdicionaInvestimento(valorInvestimento);
            Console.WriteLine(conta.Saldo);
        }

        private IInvestmentStrategy GetTypeStrategy(List<IInvestmentStrategy> _strategies, int codigoTipoPerfil)
        {
            var strategy = _strategies.FirstOrDefault(s => s.CodigoTipoPerfil == codigoTipoPerfil);
            return strategy;
        }
    }
}
