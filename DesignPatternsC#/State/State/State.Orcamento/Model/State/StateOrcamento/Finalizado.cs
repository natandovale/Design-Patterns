using System;

namespace State.Orcamento.Model.State.StateOrcamento
{
    class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamentos orcamento) { }

        public void Aprova(Orcamentos orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou finalizado!");
        }

        public void Reprova(Orcamentos orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou finalizado!");
        }

        public void Finaliza(Orcamentos orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou finalizado!");
        }

        public void EmAprovacaoOrcamento(Orcamentos orcamentos)
        {
            throw new NotImplementedException();
        }
    }
}