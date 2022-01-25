﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Banco.Model.State
{
    public class Positivo : EstadoDaConta
    {
        public void Saca(Conta conta, double valor)
        {
            conta.Saldo -= valor;

            if (conta.Saldo < 0) conta.Estado = new Negativo();
        }

        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }
    }
}
