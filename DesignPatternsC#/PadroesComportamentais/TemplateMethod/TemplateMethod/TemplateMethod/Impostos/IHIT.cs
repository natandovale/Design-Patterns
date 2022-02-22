using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Impostos.Templates;
using TemplateMethod.Model;

namespace TemplateMethod.Impostos
{
    class IHIT : TemplateImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            //Possivel outra solucao
        // IList<String> noOrcamento = new List<String>();

        //    foreach (Item item in orcamento.Itens)
        //    {
        //        if (noOrcamento.Contains(item.Nome))
        //            return true;
        //        else
        //            noOrcamento.Add(item.getNome);
        //    }

        //    return false;
        //}

            for (int i = 0; i<orcamento.Itens.Count; i++)
            {
                for (int j = i + 1; j<orcamento.Itens.Count; j++)
                {
                    if (j != i && orcamento.Itens[j].Nome == orcamento.Itens[i].Nome)
                    {
                        return true;
                    }
                }
}

return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
{
    return (orcamento.Valor * 0.13) + 100;
}

protected override double MinimaTaxacao(Orcamento orcamento)
{
    return (orcamento.Valor * 0.01) * orcamento.Itens.Count;
}
    }
}
