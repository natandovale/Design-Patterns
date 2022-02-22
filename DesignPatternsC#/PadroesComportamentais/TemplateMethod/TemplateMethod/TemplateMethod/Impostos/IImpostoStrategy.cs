using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Model;

namespace TemplateMethod.Impostos
{
   public interface IImpostoStrategy
        {
            double Calcula(Orcamento orcamento);
        }
}
