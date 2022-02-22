using Observer.NotaFiscal.Observer.Interfaces;

namespace Observer.NotaFiscal.Observer
{
    public class EnviadorDeSms : IAcaoAposGerarNotaObserver
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("enviando por sms");
        }
    }
}
