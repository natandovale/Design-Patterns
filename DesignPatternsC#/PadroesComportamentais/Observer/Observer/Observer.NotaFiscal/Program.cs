using Observer.NotaFiscal;
using Observer.NotaFiscal.Observer;

NotaFiscalBuilder builder = new NotaFiscalBuilder();
builder.AdicionaAcao(new EnviadorDeEmail());
builder.AdicionaAcao(new DaoNotaFiscal());
builder.AdicionaAcao(new EnviadorDeSms());
builder.AdicionaAcao(new Impressora());


var item = new ItemDaNotaBuilder();
NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
                  .ComCnpj("123.456.789/0001-10")
                  .Com(item.ComDescricao("Leite").ComValor(5.5))
                  .Com(item.ComDescricao("Nescal").ComValor(7.0))
                  .ComObservacoes("entregar nf pessoalmente")
                  .Constroi();
