using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PattenBuilder.NotasFiscais
{
    public class ItemDaNotaBuilder
    {
        public string Descricao { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNotaBuilder ComDescricao(string descricao)
        {
            Descricao = descricao;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            Valor = valor;
            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Descricao, Valor);
        }
    }
}
