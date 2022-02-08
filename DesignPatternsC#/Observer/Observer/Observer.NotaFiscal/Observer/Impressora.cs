using Observer.NotaFiscal.Observer.Interfaces;

namespace Observer.NotaFiscal.Observer
{
    public class Impressora : IAcaoAposGerarNotaObserver
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("imprimindo notaFiscal");
        }
    }
}
