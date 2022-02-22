using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Bussines
{
    public class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, IImpostoStrategy estrategiaDeImposto)
        {
            double valor = estrategiaDeImposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
