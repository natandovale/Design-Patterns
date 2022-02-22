namespace PattenBuilder.NotasFiscais
{
    class Teste
    {
        public static void Main(string[] args)
        {
            var item = new ItemDaNotaBuilder();
            var nf = new NotaFiscalBuilder().ParaEmpresa("Caelum")
                              .ComCnpj("123.456.789/0001-10")
                              .Com(item.ComDescricao("Leite").ComValor(5.5))
                              .Com(item.ComDescricao("Nescal").ComValor(7.0))
                              .ComObservacoes("entregar nf pessoalmente")
                              .Constroi();
        }
    }
}
