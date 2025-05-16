using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopUpSaldo.Model
{
    public class Saldo
    {
        private static decimal saldo = 0;

        public virtual decimal GetSaldo()
        {
            return saldo;
        }

        public void AddSaldo(decimal jumlah)
        {
            saldo += jumlah;
        }
    }
}
