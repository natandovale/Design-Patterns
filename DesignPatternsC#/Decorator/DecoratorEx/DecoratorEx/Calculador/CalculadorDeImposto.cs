using DecoratorEx.Impostos;
using DecoratorEx.Model;
using System;

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
