using State.Orcamento.Model.State.StateOrcamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Orcamento.Model
{
    public class Orcamentos
    {
        public double Valor { get; set; }
        public IEstadoDeUmOrcamento EstadoAtual { get; set; } // veja a mudança aqui

        public Orcamentos(double valor)
        {
            Valor = valor;
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void EmAprovacao()
        { 
            EstadoAtual = new EmAprovacao();
            EstadoAtual.EmAprovacaoOrcamento(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
