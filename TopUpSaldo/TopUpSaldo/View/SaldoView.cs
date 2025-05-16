using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopUpSaldo.View
{
    public class SaldoView
    {
        public void LihatMenu()
        {
            Console.WriteLine("=== Menu Saldo ===");
            Console.WriteLine("1. Top Up Saldo");
            Console.WriteLine("2. Lihat Saldo");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilih menu: ");
        }

        public void LihatPesan(string pesan)
        {
            Console.WriteLine(pesan);
        }

        public string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public void LihatSaldo(decimal saldo)
        {
            string formatRupiah = string.Format(new CultureInfo("id-ID"), "Rp {0:N0}", saldo);
            Console.WriteLine($"Saldo Anda: {formatRupiah}");
        }
    }
}
