using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopUpSaldo.Model;
using TopUpSaldo.View;

namespace TopUpSaldo.Service
{
    // Menggunakan dictionary sebagai table penyimpan data
    public class SaldoService
    {
        private readonly SaldoView view;
        private readonly Saldo saldo;

        // Table driven: dictionary untuk menyimpan data saldo pengguna
        private readonly Dictionary<string, decimal> tabelSaldo;

        public SaldoService(SaldoView view, Saldo saldo)
        {
            this.view = view;
            this.saldo = saldo;

            // Inisialisasi table dengan saldo dari model
            tabelSaldo = new Dictionary<string, decimal>
            {
                { "user1", saldo.GetSaldo() }
            };
        }

        public void HandleLihatSaldo()
        {
            tabelSaldo["user1"] = saldo.GetSaldo();

            view.LihatSaldo(tabelSaldo["user1"]);

            view.GetInput("Tekan Enter untuk kembali");
        }
    }
}
