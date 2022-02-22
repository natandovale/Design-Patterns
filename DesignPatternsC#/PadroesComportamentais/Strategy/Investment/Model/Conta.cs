using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.Model
{
    public class Conta
    {
        public double Saldo { get; set; }

        public void AdicionaInvestimento(double investimento)
        {
            Saldo += investimento;
        }
    }
}
