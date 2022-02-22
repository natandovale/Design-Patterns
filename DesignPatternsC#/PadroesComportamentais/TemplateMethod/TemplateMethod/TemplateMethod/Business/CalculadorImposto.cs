using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Impostos;
using TemplateMethod.Model;

namespace TemplateMethod.Business
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
