using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    //Calculo do imposto
    public class ImplementacaoErrada
    {
        public double RealizaCalculo(Orcamento orcamento, string tipoImposto)
        {
            var orcamentoComImposto = 0.0;
            if (tipoImposto.Equals("ICMS")) 
            {
               orcamentoComImposto = orcamento.Valor * 0.1;
            }

            if (tipoImposto.Equals("ISS"))
            {
                orcamentoComImposto = orcamento.Valor * 0.06;
            }

            if (tipoImposto.Equals("ICCC"))
            {
                orcamentoComImposto = orcamento.Valor * 0.5;
            }
            return orcamentoComImposto;
        }
    }
}
