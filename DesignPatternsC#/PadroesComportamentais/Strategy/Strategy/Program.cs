using Strategy.Bussines;
using Strategy.Impostos;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImpostoStrategy iss = new ISS();
            IImpostoStrategy icms = new ICMS();
            Orcamento orcamento = new Orcamento(500.0);
            CalculadorDeImposto calculador = new CalculadorDeImposto();

            // Calculando o ISS
            calculador.RealizaCalculo(orcamento, iss);

            // Calculando o ICMS        
            calculador.RealizaCalculo(orcamento, icms);
        }
    }
}
