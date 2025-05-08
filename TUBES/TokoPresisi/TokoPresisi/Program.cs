using System;
using System.Collections.Generic;
using TokoPresisi.Models;
using TokoPresisi.Services;
using TokoPresisi.Interfaces;

namespace TokoPresisi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi data
            var vouchers = new List<Voucher>
            {
                new Voucher { Name = "Voucher 1000 Coins", Price = 10000, GamePlatform = "Mobile Legends" },
                new Voucher { Name = "Voucher 500 Gems", Price = 50000, GamePlatform = "Free Fire" },
                new Voucher { Name = "Voucher 200 Diamonds", Price = 20000, GamePlatform = "PUBG Mobile" }
            };

            var user = new User("user123", 50000);

            var transactions = new List<Transaction>
            {
                new Transaction { TransactionId = "T001", UserId = "user123", ItemName = "Voucher 1000 Coins", Amount = 10000, Date = DateTime.Now.AddDays(-2), TransactionType = "sale" },
                new Transaction { TransactionId = "T002", UserId = "user123", ItemName = "Top Up", Amount = 50000, Date = DateTime.Now.AddDays(-1), TransactionType = "topup" }
            };

            // Inisialisasi service dengan dependency injection sederhana
            InterfacesVoucher servicesVoucher = new ServicesVoucher();
            InterfacesTransaksi servicesTransaksi = new ServicesTransaksi();
            InterfacesTopUp servicesTopUp = new ServicesTopUp();

            // Registrasi handler transaksi (table-driven)
            servicesTransaksi.RegisterTransactionHandler("sale", t =>
                Console.WriteLine($"[Penjualan] {t.Date}: User {t.UserId} membeli {t.ItemName} seharga {t.Amount}"));

            servicesTransaksi.RegisterTransactionHandler("topup", t =>
                Console.WriteLine($"[Top Up] {t.Date}: User {t.UserId} melakukan top up sebesar {t.Amount}"));

            // Menampilkan daftar voucher
            Console.WriteLine("=== Daftar Voucher Currency ===");
            servicesVoucher.DisplayVouchers(vouchers);

            // Menampilkan riwayat transaksi
            Console.WriteLine("\n=== Riwayat Penjualan dan Top Up ===");
            servicesTransaksi.DisplayTransactions(transactions);

            // Fitur top up saldo
            Console.WriteLine("\n=== Fitur Top Up Saldo ===");
            Console.WriteLine($"Saldo awal: {user.Balance}");
            Console.Write("Masukkan jumlah top up: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                Console.WriteLine("Input jumlah tidak valid.");
                return;
            }
            Console.Write("Masukkan nomor rekening (minimal 12 digit): ");
            string accountNumber = Console.ReadLine() ?? "";

            servicesTopUp.TopUp(user, amount, accountNumber);

            Console.WriteLine($"Saldo akhir: {user.Balance}");
        }
    }
}
