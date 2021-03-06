using DecoratorEx.Impostos;
using DecoratorEx.Model;
using System;

namespace DecoratorEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ImpostoMuitoAlto(new ISS(new ICMS()));

            Orcamento orcamento = new Orcamento(500);

            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);
        }
    }
}
