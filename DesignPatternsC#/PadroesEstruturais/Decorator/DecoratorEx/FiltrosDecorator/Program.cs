using FiltrosDecorator.Filtros;
using System;
using System.Collections.Generic;

namespace FiltrosDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Conta> lista = new List<Conta>()
            {
              new Conta(){Saldo = 99, DataAbertura = new DateTime(2022,1,1)},
              new Conta(){Saldo = 159, DataAbertura = new DateTime(2022,1,1)},
              new Conta(){Saldo = 500.001, DataAbertura = new DateTime(2022,1,1)},
            };
            
            var con = new MaiorQue500KFiltro(new MenorQue100Filtro(new MesmoMesFiltro()));
            var c = con.Filtra(lista);

            foreach (var item in c)
            {
                Console.WriteLine(item.Saldo);
            }

        }
    }
}
