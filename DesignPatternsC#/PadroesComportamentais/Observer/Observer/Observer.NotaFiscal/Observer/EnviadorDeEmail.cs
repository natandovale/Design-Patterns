using Observer.NotaFiscal.Observer.Interfaces;

namespace Observer.NotaFiscal.Observer
{
    public class EnviadorDeEmail : IAcaoAposGerarNotaObserver
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("enviando por e-mail");
        }
    }
}
