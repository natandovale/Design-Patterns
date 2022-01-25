using System;

namespace State.Orcamento.Model.State.StateOrcamento
{
    class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamentos orcamento) { }

        public void Aprova(Orcamentos orcamento)
        {
            throw new Exception("Orçamento está em estado de reprovação, não pode aprovar agora!");
        }

        public void Reprova(Orcamentos orcamento)
        {
            throw new Exception("Já estou reprovado!");
        }

        public void Finaliza(Orcamentos orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void EmAprovacaoOrcamento(Orcamentos orcamentos)
        {
            throw new NotImplementedException();
        }
    }
}