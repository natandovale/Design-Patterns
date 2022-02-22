
namespace State.Orcamento.Model.State.StateOrcamento
{
    public interface IEstadoDeUmOrcamento
    {
        void AplicaDescontoExtra(Orcamentos orcamento);
        void EmAprovacaoOrcamento(Orcamentos orcamentos);
        void Aprova(Orcamentos orcamento);
        void Reprova(Orcamentos orcamento);
        void Finaliza(Orcamentos orcamento);
    }
}
