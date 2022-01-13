using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrosDecorator.Filtros
{
    public class MaiorQue500KFiltro : Filtro
    {

        public MaiorQue500KFiltro(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public MaiorQue500KFiltro() : base()
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();

            foreach (var item in contas)
            {
                if(item.Saldo > 500.000)
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
