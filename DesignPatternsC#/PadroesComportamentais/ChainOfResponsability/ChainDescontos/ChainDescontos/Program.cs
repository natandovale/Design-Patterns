using ChainDescontos.Business;
using ChainDescontos.Model;
using System;

namespace ChainDescontos
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDesconto calc = new CalculadorDesconto();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Lapis", 250));
            orcamento.AdicionaItem(new Item("Caneta", 25));
            orcamento.AdicionaItem(new Item("Geladeira", 2));
            orcamento.AdicionaItem(new Item("Fogao", 250));
            orcamento.AdicionaItem(new Item("Microondas", 250));
            orcamento.AdicionaItem(new Item("Xbox", 250));

            double desconto = calc.Calcula(orcamento);
            Console.WriteLine(desconto);
        }
    }
}
