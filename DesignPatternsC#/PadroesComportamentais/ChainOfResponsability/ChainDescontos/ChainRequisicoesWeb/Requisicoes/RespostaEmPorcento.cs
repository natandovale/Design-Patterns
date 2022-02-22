using ChainRequisicoesWeb.Model;
using ChainRequisicoesWeb.Requisicoes.Enum;
using ChainRequisicoesWeb.Requisicoes.Interface;
using System;

namespace ChainRequisicoesWeb.Requisicoes
{
    class RespostaEmPorcento : IResposta
    {
        public IResposta Proximo { get; set; }

        public void Tratamento(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            Proximo.Tratamento(req, conta);
        }
    }
}
