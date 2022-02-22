using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrosDecorator.Filtros
{
    public class MenorQue100Filtro : Filtro
    {

        public MenorQue100Filtro(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public MenorQue100Filtro() : base()
        {
        }
        
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();

            foreach (var item in contas)
            {
                if (item.Saldo < 100)
                {
                    filtrada.Add(item);
                }
            }
            foreach (Conta c in Proximo(contas))
            {
                filtrada.Add(c);
            }

            return filtrada;
        }
    }
}
