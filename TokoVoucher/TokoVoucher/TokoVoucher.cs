using coba;
using System;
using System.Collections.Generic;
using TransactionLibrary;

namespace coba
{
    public class Voucher
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Platform { get; set; }
    }

    public class Transaction
    {
        public string VoucherName { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }

    public class VoucherSystem
    {
        private List<Voucher> vouchers = new List<Voucher>();
        private TransactionService transactionService = new TransactionService();

        // Menu Utama
        public void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== Menu Utama ===");
                Console.WriteLine("1. Pembeli");
                Console.WriteLine("2. Toko");
                Console.WriteLine("3. Keluar");

                Console.Write("Pilih menu: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BuyerMenu();
                        break;
                    case "2":
                        StoreMenu();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }
            }
        }

        // Menu Pembeli
        private void BuyerMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== Menu Pembeli ===");
                ShowAllVouchers();
                Console.WriteLine("1. Beli Voucher");
                Console.WriteLine("2. Lihat Riwayat");
                Console.WriteLine("3. Kembali");

                Console.Write("Pilih menu: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BuyVoucher();
                        break;
                    case "2":
                        ShowHistory();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }
            }
        }

        // Menu Toko
        private void StoreMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== Menu Toko ===");
                Console.WriteLine("1. Tambah Voucher");
                Console.WriteLine("2. Lihat Semua Voucher");
                Console.WriteLine("3. Update Voucher");
                Console.WriteLine("4. Hapus Voucher");
                Console.WriteLine("5. Kembali");

                Console.Write("Pilih menu: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddVoucherFromInput();
                        break;
                    case "2":
                        ShowAllVouchers();
                        break;
                    case "3":
                        UpdateVoucher();
                        break;
                    case "4":
                        DeleteVoucher();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }
            }
        }

        // Tambah, Lihat, Update, Hapus Voucher Toko
        private void AddVoucherFromInput()
        {
            try
            {
                Console.WriteLine("\n=== Tambah Voucher Baru ===");

                Console.Write("Masukkan Nama Voucher: ");
                string name = Console.ReadLine();

                Console.Write("Masukkan Harga Voucher: ");
                int price = int.Parse(Console.ReadLine());

                Console.Write("Masukkan Platform Game: ");
                string platform = Console.ReadLine();

                vouchers.Add(new Voucher { Name = name, Price = price, Platform = platform });
                Console.WriteLine("Voucher berhasil ditambahkan!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            }
        }

        private void ShowAllVouchers()
        {
            Console.WriteLine("\n=== Daftar Voucher ===");
            if (vouchers.Count == 0)
                Console.WriteLine("Tidak ada voucher.");

            foreach (var voucher in vouchers)
            {
                Console.WriteLine($"Nama: {voucher.Name}, Harga: {voucher.Price}, Platform: {voucher.Platform}");
            }
        }

        public void UpdateVoucher()
        {
            Console.Write("Masukkan Nama Voucher yang akan di ganti: ");
            string nama = Console.ReadLine();

            var voucher = vouchers.Find(v => v.Name.Equals(nama));
            if (voucher != null)
            {
                Console.Write("Nama baru: ");
                voucher.Name = Console.ReadLine();

                Console.Write("Harga Baru: ");
                voucher.Price = int.Parse(Console.ReadLine());

                Console.Write("Platform baru: ");
                voucher.Platform = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Voucher tidak ditemukan!");
            }
        }

        public void DeleteVoucher()
        {
            Console.Write("Masukkan Nama Voucher yang akan dihapus: ");
            string nama = Console.ReadLine();

            int removed = vouchers.RemoveAll(v => v.Name.Equals(nama));
            if (removed > 0)
            {
                Console.WriteLine("Voucher berhasil dihapus!");
            }
            else
            {
                Console.WriteLine("Voucher tidak ditemukan!");
            }
        }


        // Pembelian
        private void BuyVoucher()
        {
            try
            {
                Console.Write("Pilih Nama Voucher: ");
                string name = Console.ReadLine();
                Voucher voucher = vouchers.Find(v => v.Name.Equals(name));

                if (voucher != null)
                {
                    Console.Write("Masukkan Jumlah: ");
                    int quantity = int.Parse(Console.ReadLine());

                    int totalPrice = voucher.Price * quantity;
                    transactionService.Add(name, quantity, totalPrice);

                    Console.WriteLine($"Total Harga: {totalPrice}");
                }
                else
                {
                    Console.WriteLine("Voucher tidak ditemukan!");
                }
            }
            catch (Exception ex) {Console.WriteLine("Input Tdak Valid"); } 
        }

        private void ShowHistory()
        {
            Console.WriteLine("\n=== Riwayat Transaksi ===");
            var history = transactionService.GetAll();

            if (!history.Any())
                Console.WriteLine("Tidak ada riwayat transaksi.");

            foreach (var transaction in history)
            {
                Console.WriteLine($"Voucher: {transaction.VoucherName}, " +
                    $"Jumlah: {transaction.Quantity}, Total: {transaction.TotalPrice}");
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        VoucherSystem system = new VoucherSystem();
        system.MainMenu();
    }
}
