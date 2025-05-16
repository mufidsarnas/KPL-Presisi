using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopUpSaldo.Model;
using TopUpSaldo.View;

namespace TopUpSaldo.Service
{
    // Generic untuk validasi input
    public class TopUpService
    {
        private readonly SaldoView view;
        private readonly Saldo saldo;

        public TopUpService(SaldoView view, Saldo saldo)
        {
            this.view = view;
            this.saldo = saldo;
        }

        // Generic untuk validasi input dengan predicate
        private bool ValidasiInput<T>(string input, Func<T, bool> validator, out T hasil, string errorMessage)
        {
            hasil = default;
            try
            {
                // Konversi input ke tipe T
                var konversi = (T)Convert.ChangeType(input, typeof(T));
                if (!validator(konversi))
                {
                    view.LihatPesan(errorMessage);
                    return false;
                }
                hasil = konversi;
                return true;
            }
            catch
            {
                view.LihatPesan(errorMessage);
                return false;
            }
        }

        public void HandleTopUp()
        {
            while (true)
            {
                string inputNominal = view.GetInput("Masukkan nominal top up (minimal Rp 10.000, maksimal Rp 10.000.000): ");
                if (!ValidasiInput<decimal>(inputNominal,
                    jumlah => jumlah >= 10000 && jumlah <= 10000000,
                    out decimal nominal,
                    "Jumlah Nominal tidak valid"))
                {
                    continue;
                }

                view.LihatPesan("Pilih aksi lanjutan:");
                view.LihatPesan("1. Lanjut ke pembayaran");
                view.LihatPesan("2. Batalkan pembelian");
                string pilihPembayaran = view.GetInput("Pilihan: ");

                if (pilihPembayaran == "2")
                {
                    view.LihatPesan("Pembayaran dibatalkan, kembali ke menu utama.");
                    break;
                }
                else if (pilihPembayaran == "1")
                {
                    if (!InputKartuDanPin())
                    {
                        continue;
                    }
                    saldo.AddSaldo(nominal);
                    view.LihatPesan("Top up berhasil!");
                    break;
                }
                else
                {
                    view.LihatPesan("Pilihan tidak valid, kembali ke menu pembayaran.");
                }
            }
        }

        private bool InputKartuDanPin()
        {
            string nomorKartu = view.GetInput("Masukkan nomor kartu kredit/debit (16 digit): ");
            if (!ValidasiInput<string>(nomorKartu,
                s => s.Length == 16 && long.TryParse(s, out _),
                out string _,
                "Nomor kartu harus 16 digit angka, silahkan top up ulang"))
            {
                return false;
            }

            string pin = view.GetInput("Masukkan PIN (6 digit): ");
            if (!ValidasiInput<string>(pin,
                s => s.Length == 6 && int.TryParse(s, out _),
                out string _,
                "PIN harus 6 digit angka, silahkan top up ulang"))
            {
                return false;
            }

            return true;
        }
    }
}
