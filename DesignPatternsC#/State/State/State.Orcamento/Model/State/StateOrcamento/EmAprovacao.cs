using System;

namespace State.Orcamento.Model.State.StateOrcamento
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamentos orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Não pode aplicar mais de 2 vezes o mesmo desconto");
            }
        }

        public void Aprova(Orcamentos orcamento)
        {
            // desse estado posso ir para o estado de aprovado
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orcamentos orcamento)
        {
            // desse estado posso ir para o estado de reprovado tambem
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamentos orcamento)
        {
            // daqui não posso ir direto para finalizado
            throw new Exception("Orcamento em aprovação não podem ir para finalizado diretamente");
        }

        public void EmAprovacaoOrcamento(Orcamentos orcamento)
        {
            orcamento.EstadoAtual = new EmAprovacao();
        }
    }
}
