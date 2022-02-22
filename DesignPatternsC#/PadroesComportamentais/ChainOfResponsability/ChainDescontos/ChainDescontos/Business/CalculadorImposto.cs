using ChainDescontos.Impostos;
using ChainDescontos.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainDescontos.Business
{
    public class CalculadorImposto
    {
        public void RealizaCalculo(Orcamento orcamento, IImpostoStrategy estrategiaDeImposto)
        {
            double valor = estrategiaDeImposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
