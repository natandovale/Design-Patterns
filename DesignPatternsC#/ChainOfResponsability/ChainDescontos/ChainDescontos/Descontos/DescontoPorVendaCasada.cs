using ChainDescontos.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainDescontos.Descontos
{
    class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            bool temLapis = Existe("LAPIS", orcamento);
            bool temCaneta = Existe("CANETA", orcamento);
            if (temCaneta && temLapis)
                return orcamento.Valor * 0.5;
            return 0;
        }

        private bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
