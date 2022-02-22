using ChainRequisicoesWeb.Model;
using ChainRequisicoesWeb.Requisicoes.Enum;
using ChainRequisicoesWeb.Requisicoes.Interface;
using System;

namespace ChainRequisicoesWeb.Requisicoes
{
    class RespostaEmXml : IResposta
    {
        public IResposta Proximo { get; set; }

        public void Tratamento(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            Proximo.Tratamento(req, conta);
        }
    }

}
