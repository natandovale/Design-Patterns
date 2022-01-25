using System;
using State.Orcamento.Model;

namespace State.Orcamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var reforma = new Orcamentos(500.00);
            reforma.EmAprovacao();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);
            reforma.Aprova(); 

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Finaliza();
        }
    }
}
