using System;
using System.Collections.Generic;
using System.Text;

namespace ChainDescontos.Model
{
    public class Item
    {
        public string Nome { get; private set; }
        public double Valor { get; set; }

        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
