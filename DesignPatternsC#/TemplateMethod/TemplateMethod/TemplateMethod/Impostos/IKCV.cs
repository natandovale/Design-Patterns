﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Impostos.Templates;
using TemplateMethod.Model;

namespace TemplateMethod.Impostos
{
    public class IKCV : TemplateImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && ItemMaiorQue100ReaisNo(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        private bool ItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;
        }
    }
}
