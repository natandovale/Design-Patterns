using System.Collections.Generic;

namespace FiltrosDecorator.Filtros
{
    public abstract class Filtro
    {
        public IList<Conta> contasFiltradas = new List<Conta>();
        public Filtro OutroFiltro { get; set; }
        public Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        public Filtro()
        {
            OutroFiltro = null;
        }

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        public IList<Conta> Proximo(IList<Conta> contas)
        {
            if (OutroFiltro != null) return OutroFiltro.Filtra(contas);
            else return new List<Conta>();
        }
    }
}

