using ChainRequisicoesWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainRequisicoesWeb.Requisicoes.Interface
{
    public interface IResposta
    {
        IResposta Proximo { get; set; }
        void Tratamento(Requisicao requisicao, Conta conta);
    }
}
