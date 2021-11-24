using StrategyAplication.Business;
using StrategyAplication.CalcularPagamento.PagamentoAVista;
using StrategyAplication.CalcularPagamentoDesconto.Interface;
using StrategyAplication.CalcularPagamentoDesconto.PagamentoAVista;
using StrategyAplication.Models;
using System;
using System.Collections.Generic;

namespace StrategyAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var livro = new Livro {Preco=40.6};
            var revistaFisico = new RevistaFisico {Preco=25.6};
            var jogoTabuleiro = new JogoTabuleiro {Preco=30.6};
            List<Produto> listaDesconto1 = new List<Produto>
            {
                livro,
                revistaFisico,
                jogoTabuleiro
            };

            ICalcularDescontoStrategy desc1 = new LivroRevistaFisicoJogoTabuleiroStrategy();
            ICalcularDescontoStrategy desc2 = new LivroRevistaDigitalStrategy();
            List<ICalcularDescontoStrategy> descontoStrategies = new List<ICalcularDescontoStrategy>
            {
                desc1,
                desc2
            };

            var calc = new CalculadorDesconto(descontoStrategies);
            calc.RealizaCalculo(listaDesconto1, 1);
        }
    }
}
