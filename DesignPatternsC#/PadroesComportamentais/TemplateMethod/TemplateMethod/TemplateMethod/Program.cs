using System;
using TemplateMethod.Business;
using TemplateMethod.Impostos;
using TemplateMethod.Model;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new("Abacaxi", 2.4);
            Item item2 = new("Maca", 2.4);
            Item item3 = new("Uva", 2.4);
            Item item4 = new("Abacaxi", 2.4);

            var orcamento = new Orcamento(500);
            orcamento.AdicionaItem(item1);
            orcamento.AdicionaItem(item2);
            orcamento.AdicionaItem(item3);
            orcamento.AdicionaItem(item4);

            var ikcv = new IKCV();
            var ihit = new IHIT();

            var calc = new CalculadorImposto();
            calc.RealizaCalculo(orcamento, ihit);
        }
    }
}
