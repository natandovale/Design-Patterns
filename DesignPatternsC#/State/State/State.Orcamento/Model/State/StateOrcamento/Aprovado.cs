using System;

namespace State.Orcamento.Model.State.StateOrcamento
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamentos orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Não pode aplicar mais de 2 vezes o mesmo desconto");
            }
        }

        public void Aprova(Orcamentos orcamento)
        {
            // jah estou em aprovacao
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Reprova(Orcamentos orcamento)
        {
            // nao pode ser reprovado agora!
            throw new Exception("Orçamento está em estado de aprovação e não pode ser reprovado");
        }

        public void Finaliza(Orcamentos orcamento)
        {
            // daqui posso ir para o estado de finalizado
            orcamento.EstadoAtual = new Finalizado();
        }

        public void EmAprovacaoOrcamento(Orcamentos orcamentos)
        {
            throw new Exception("Orçamento ja foi aprovado");
        }
    }
}
