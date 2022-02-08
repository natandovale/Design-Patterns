using Observer.NotaFiscal.Observer.Interfaces;

namespace Observer.NotaFiscal.Observer
{
    public class DaoNotaFiscal : IAcaoAposGerarNotaObserver
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("salvando no banco");
        }
    }

}
