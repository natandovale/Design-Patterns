using DecoratorEx.Impostos;
using DecoratorEx.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorEx.Calculador
{
    public class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto estrategiaDeImposto)
        {
            double valor = estrategiaDeImposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
