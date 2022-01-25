using State.Banco.Model.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Banco.Model
{
    public class Conta
    {
        public double Saldo { get; set; }
        protected EstadoDaConta Estado;

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }
    }
}
