﻿using ChainDescontos.Descontos;
using ChainDescontos.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainDescontos.Business
{
    public class CalculadorDesconto
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconta(orcamento);
        }
    }
}
