using Observer.NotaFiscal.Observer.Interfaces;

namespace Observer.NotaFiscal
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public double ValorTotal { get; private set; }
        public double Impostos { get; private set; }
        public DateTime Data { get; private set; }
        public string Observacoes { get; private set; }
        public double ValorBruto { get; private set; }
        private readonly IList<ItemDaNota> TodosItens = new List<ItemDaNota>();
        private readonly IList<IAcaoAposGerarNotaObserver> todasAcoesASeremExecutadas;

        public NotaFiscalBuilder()
        {
            Data = DateTime.Now;
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this; // retorno eu mesmo, o próprio builder, para que o cliente continue utilizando
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string obs)
        {
            Observacoes = obs;
            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNotaBuilder itemBuilder)
        {
            ItemDaNota item = new(itemBuilder.Descricao, itemBuilder.Valor);
            TodosItens.Add(item);
            ValorBruto += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime data)
        {
            Data = data;
            return this;
        }

        public void AdicionaAcao(IAcaoAposGerarNotaObserver novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }

        public NotaFiscal Constroi()
        {
            var notaFiscal = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorBruto, Impostos, TodosItens, Observacoes);

            foreach (var acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(notaFiscal);
            }

            return notaFiscal;
        }
    }
}
