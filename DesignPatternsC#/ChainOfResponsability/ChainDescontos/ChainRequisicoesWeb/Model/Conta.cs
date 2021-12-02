﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainRequisicoesWeb.Model
{
    public class Conta
    {
        public String Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}
